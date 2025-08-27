using Aris3._0.Infrastructure.Data.Context;
using Aris3._0Fe.Models;
using Aris3._0Fe.Services;
using Aris3._0FE.Data.Context;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MimeKit;
using System.Security.Claims;
using X.PagedList;
public class UserController : Controller
{
    private readonly ArisDbContext dbContext;
    private readonly SendEmail sendEmail;

    public UserController(ArisDbContext dbContext,SendEmail _sendEmail)
    {
        this.dbContext = dbContext;
        sendEmail = _sendEmail;
    }
    public IActionResult UserProfile()
    {
        return View(dbContext.Accounts.ToList());
    }
    public IActionResult ForgotPassword()
    {
        return View();
    }
    public IActionResult VerifyMail()
    {
        return View();
    }
    public IActionResult SignUp()
    {
        return View();
    }
    public IActionResult Step2()
    {
        return View();
    }
    public IActionResult LogOut()
    {
        HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Index", "Home");
    }
    [Authorize]
    public async Task<IActionResult> Profiles()
    {
        var userId = User.FindFirstValue("AccountId");
        if (userId == null)
            return RedirectToAction("Login");

        // Get user account
        var account = await dbContext.Accounts
            .Include(a => a.Subscription) 
            .Include(a=>a.SubscriptionHistories)
            .FirstOrDefaultAsync(a => a.Id.ToString() == userId);

        if (account == null)
            return RedirectToAction("Login");

        return View(account);
    }
    [HttpGet]
    public IActionResult PickPlan(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            ModelState.AddModelError("", "Email is required.");
            return RedirectToAction("SignUp"); 
        }
        TempData["Email"] = email;
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> SendEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            ModelState.AddModelError("", "Email is required.");
            return View("ForgotPassword");
        }

        var result = await sendEmail.SendVerificationEmailAsync(email);
        TempData["EmailResult"] = result;
        return RedirectToAction("VerifyMail");
    }
    [HttpGet]
    public async Task<IActionResult> VerifyOtp(int code)
    {
        var person = await dbContext.Otps.FirstOrDefaultAsync(t=>t.Code == code&&t.ExpireAt > DateTime.Now);
        
        if(person != null) return RedirectToAction("Index", "Home");
        return RedirectToAction("ForgotPassword");
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(Account account)
    {
        var user = dbContext.Accounts
                    .FirstOrDefault(u => u.Email == account.Email && EF.Functions.Collate(u.Password,"Latin1_General_CS_AS") == account.Password);
        if (user == null)
        {
            ModelState.AddModelError("", "Invalid email or password");
            return View(account);
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),  
            new Claim("AccountId", user.Id.ToString()),         
            new Claim(ClaimTypes.Role, user.Role)
        };


        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);

        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

        return RedirectToAction("Index", "Home");
    }
    
}


