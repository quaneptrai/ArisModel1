using Aris3._0Fe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Net;
using System.Text;
using System.Security.Claims;
using Aris3._0FE.Data.Context;
using X.PagedList;
using X.PagedList.Extensions;
namespace Aris3._0Fe.Controllers
{
    public class FilmController : Controller
    {
        private readonly ArisDbContext dbContext;

        public FilmController(ArisDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index(string id, string posterurl, string name, string original_name, string thumburl)
        {
            var episodeArray = new List<Episode>();
            bool isLiked = false;

            if (id != null)
            {
                var film = dbContext.Films.FirstOrDefault(f => f.Id == id);
                if (film != null)
                {
                    film.View += 1;
                    dbContext.SaveChanges();
                }

                episodeArray = dbContext.Episodes.Where(e => e.Server.Film.Id == id)
                                     .Include(s => s.Server)
                                         .ThenInclude(s => s.Film)
                                          .ThenInclude(f => f.Countries)
                                .Include(s => s.Server)
                                        .ThenInclude(s => s.Film)
                                        .ThenInclude(f => f.Categories)
                                .Include(s => s.Server)
                                        .ThenInclude(s => s.Film)
                                        .ThenInclude(f => f.Actors)
                                 .ToList();
                if (User.Identity.IsAuthenticated)
                {
                    var accountIdClaim = User.FindFirst(ClaimTypes.NameIdentifier) ??
                                         User.FindFirst("AccountId") ??
                                         User.Claims.FirstOrDefault(c => c.Type == "Id");

                    if (accountIdClaim != null)
                    {
                        var accountId = Guid.Parse(accountIdClaim.Value);
                        var currentEpisode = episodeArray.FirstOrDefault();

                        var existingHistory = dbContext.Histories
                            .FirstOrDefault(h => h.AccountId == accountId && h.FilmId == id);

                        if (existingHistory != null)
                        {
                            if (currentEpisode != null)
                            {
                                existingHistory.CurrentEpisodeId = currentEpisode.Id;
                            }
                            else
                            {
                                existingHistory.CurrentEpisodeId = null;
                            }
                            existingHistory.LastWatched = DateTime.UtcNow;
                            dbContext.Histories.Update(existingHistory);
                        }
                        else
                        {
                            var history = new History
                            {
                                AccountId = accountId,
                                FilmId = id,
                                CurrentEpisodeId = currentEpisode?.Id,
                                LastWatched = DateTime.UtcNow,
                                WatchDuration = 0
                            };
                            dbContext.Histories.Add(history);
                        }
                        dbContext.SaveChanges();
                    }
                }
            }
            var userId = User.FindFirst("AccountId");
            if (userId != null)
            {
                var userIdparsed = Guid.Parse(userId.Value);
                isLiked = dbContext.LikedFilms
                               .Any(lf => lf.AccountId == userIdparsed && lf.FilmId == id);
            }

            ViewBag.IsLiked = isLiked;
            return View(episodeArray);
        }
        [HttpPost]
        public async Task<IActionResult> AddingLikeFilm(string Id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized("Please log in to like films");
            }

            var accountIdClaim = User.FindFirst(ClaimTypes.NameIdentifier) ?? 
                                User.FindFirst("AccountId") ??
                                User.Claims.FirstOrDefault(c => c.Type == "Id");

            if (accountIdClaim == null)
                    {
                return Unauthorized("User ID not found in claims. Please log in again.");
            }

            var accountId = Guid.Parse(accountIdClaim.Value);

            // Check if Account exists in DB before proceeding
            var account = await dbContext.Accounts.FirstOrDefaultAsync(a => a.Id == accountId);
            if (account == null)
            {
                return BadRequest("Account does not exist. Please log in again.");
            }

            // Check if related Person exists for this Account (only if PersonId is not empty)
            if (account.PersonId != Guid.Empty)
            {
                var personExists = await dbContext.Persons.AnyAsync(p => p.id == account.PersonId);
                if (!personExists)
                {
                    return BadRequest("Related Person does not exist for this account.");
                }
            }

            var film = await dbContext.Films.FirstOrDefaultAsync(f => f.Id == Id);
            if (film == null)
            {
                return NotFound("Phim không tồn tại.");
            }

            var existingLike = await dbContext.LikedFilms
                .FirstOrDefaultAsync(lf => lf.AccountId == accountId && lf.FilmId == Id);

            if (existingLike != null)
            {
                film.Like -= 1;
                dbContext.LikedFilms.Remove(existingLike);
                await dbContext.SaveChangesAsync();
                return Ok(new { message = "Đã bỏ thích phim!", likes = film.Like });
            }

            film.Like += 1;

            var likedFilm = new LikedFilms
            {
                AccountId = account.Id, // FK only
                FilmId = film.Id,       // FK only
                FilmName = film.Name,
                AddedAt = DateTime.UtcNow
            };
            dbContext.LikedFilms.Add(likedFilm);
            await dbContext.SaveChangesAsync();

            return Ok(new { message = "Đã thích phim thành công!", likes = film.Like });
        }
        [HttpGet]
        public async Task<IActionResult> Search(string searchQuery, Guid id, string category, int? page)
        {
            int pageSize = 12;
            int pageNumber = page ?? 1;

            IQueryable<Film> filmsQuery = dbContext.Films.AsQueryable();

            // Case 1: Search by query
            if (!string.IsNullOrWhiteSpace(searchQuery) && id == Guid.Empty && string.IsNullOrEmpty(category))
            {
                string RemoveDiacritics(string text)
                {
                    if (string.IsNullOrEmpty(text)) return text;
                    var normalized = text.Normalize(NormalizationForm.FormD);
                    var sb = new StringBuilder();
                    foreach (var c in normalized)
                    {
                        if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                            sb.Append(c);
                    }
                    return sb.ToString().Normalize(NormalizationForm.FormC).ToLower();
                }

                string keywordStart = RemoveDiacritics(searchQuery.Length >= 3
                                                       ? searchQuery.Substring(0, 3)
                                                       : searchQuery);

                // ✅ Pull into memory here
                var filmsList = await filmsQuery.ToListAsync();

                filmsQuery = filmsList
                             .Where(f => !string.IsNullOrEmpty(f.Name) &&
                                         RemoveDiacritics(f.Name).StartsWith(keywordStart))
                             .AsQueryable();

                ViewBag.TuKhoa = searchQuery;
            }
            // Case 2: Search by category
            else if (string.IsNullOrWhiteSpace(searchQuery) && id == Guid.Empty && !string.IsNullOrEmpty(category))
            {
                var decodedCategory = WebUtility.UrlDecode(category).Trim();

                filmsQuery = filmsQuery.Include(f => f.Categories)
                                       .Where(f => f.Categories.Any(c => c.Name.ToLower() == decodedCategory.ToLower()));

                var cate = await dbContext.Categories
                                          .FirstOrDefaultAsync(c => c.Name.ToLower() == decodedCategory.ToLower());
                ViewBag.CateFind = cate?.Name;
            }
            // Case 3: Search by country
            else if (id != Guid.Empty)
            {
                filmsQuery = filmsQuery.Include(f => f.Countries)
                                       .Where(f => f.Countries.Any(c => c.Id == id));

                var cotry = await dbContext.Countries.FirstOrDefaultAsync(c => c.Id == id);
                ViewBag.CountryFind = cotry?.Name;
            }

            // Execute query & paginate
            var filmsPaged =      filmsQuery
                                    .OrderBy(f => f.Name)
                                    .ToPagedList(pageNumber, pageSize);

            ViewBag.Count = filmsPaged.TotalItemCount;

            return View(filmsPaged);
        }
    }
}