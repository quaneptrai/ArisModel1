using Aris3._0.Application.DTOs;
using Aris3._0.Domain.Entities;
using Aris3._0.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aris3._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ArisDbContext dbContext;

        public AccountController(ArisDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("{email}")]
        public IActionResult GetAccountByEmail(string email)
        {
            var account = dbContext.Set<Account>().FirstOrDefault(a => a.Email == email);
            if (account == null)
            {
                return NotFound(new { Message = "Account not found" });
            }
            return Ok(account);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount([FromBody] AccountCreateDto dto)
        {
            Account account;
            if (string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Password))
                return BadRequest("Email and Password are required.");
            var existingAccount = await dbContext.Accounts
                .FirstOrDefaultAsync(a => a.Email == dto.Email);

            if (existingAccount != null)
            {
                if(existingAccount.Password != dto.Password)
                {
                    return BadRequest(new { Message = "Wrong password !" });
                }
                existingAccount.SubscriptionId = dto.SubscriptionId;
                existingAccount.LastUpdated = DateTime.UtcNow;

                try
                {
                    await dbContext.SaveChangesAsync();
                    return Ok(new { 
                        Message = "Account subscription updated successfully", 
                        AccountId = existingAccount.Id,
                        NewSubscriptionId = dto.SubscriptionId
                    });
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { Message = "Error updating subscription", Error = ex.Message });
                }
            }
            var person = new Person
            {
                id = Guid.NewGuid(),
                Email = dto.Email,
                Name = string.Empty,
                Role = "Guest",
                PhoneNumber = string.Empty,
                City = string.Empty,
                State = string.Empty,
                Zipcode = string.Empty,
                Country = "Vn",
                Region = "Sea",
                AccountStat = true,
                Created = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            };
            if (dto.Username.Equals("string"))
            {
                account = new Account
                {
                    Id = Guid.NewGuid(),
                    Email = dto.Email,
                    Password = dto.Password,
                    UserName = dto.Email.Split("@")[0],
                    Role = "Guest",
                    status = true,
                    AccountStat = true,
                    PersonId = person.id,
                    Created = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow,
                    SubscriptionId = dto.SubscriptionId
                };

                try
                {
                    dbContext.Persons.Add(person);
                    dbContext.Accounts.Add(account);
                    await dbContext.SaveChangesAsync();

                    return Ok(new
                    {
                        Message = "Account created successfully",
                        AccountId = account.Id,
                        PersonId = person.id
                    });
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { Message = "Error creating account", Error = ex.Message });
                }
            }
            else
            {
                account = new Account
                {
                    Id = Guid.NewGuid(),
                    Email = dto.Email,
                    Password = dto.Password,
                    UserName = dto.Username,
                    Role = "Guest",
                    status = true,
                    AccountStat = true,
                    PersonId = person.id,
                    Created = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow,
                    SubscriptionId = dto.SubscriptionId
                };

                try
                {
                    dbContext.Persons.Add(person);
                    dbContext.Accounts.Add(account);
                    await dbContext.SaveChangesAsync();

                    return Ok(new
                    {
                        Message = "Account created successfully",
                        AccountId = account.Id,
                        PersonId = person.id
                    });
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { Message = "Error creating account", Error = ex.Message });
                }
            }
        }
        [HttpPost("toggle-status/{email}")]
        public async Task<IActionResult> ToggleAccountStatus(string email)
        {
            var account = await dbContext.Set<Account>().FirstOrDefaultAsync(a => a.Email == email);
            if (account == null)
            {
                return NotFound(new { Message = "Account not found" });
            }
            account.status = !account.status;
            account.LastUpdated = DateTime.UtcNow;
            try
            {
                dbContext.Set<Account>().Update(account);
                await dbContext.SaveChangesAsync();
                return Ok(new { Message = "Account status toggled successfully", NewStatus = account.status });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Error toggling account status", Error = ex.Message });
            }
        }
        [HttpDelete("{email}")]
        public async Task<IActionResult> DeleteAccount(string email)
        {
            var account = await dbContext.Set<Account>().FirstOrDefaultAsync(a => a.Email == email);
            if (account == null)
            {
                return NotFound(new { Message = "Account not found" });
            }
            try
            {
                dbContext.Set<Account>().Remove(account);
                await dbContext.SaveChangesAsync();
                return Ok(new { Message = "Account deleted successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Error deleting account", Error = ex.Message });
            }
        }
        [HttpGet("all")]
        public IActionResult GetAllAccounts()
        {
            var accounts = dbContext.Set<Account>().ToList();
            return Ok(accounts);
        }
        [HttpPut("{email}")]
        public async Task<IActionResult> UpdateAccount(string email, [FromBody] Account updatedAccount)
        {
            var account = await dbContext.Set<Account>().FirstOrDefaultAsync(a => a.Email == email);
            if (account == null)
            {
                return NotFound(new { Message = "Account not found" });
            }
            account.UserName = updatedAccount.UserName ?? account.UserName;
            account.Password = updatedAccount.Password ?? account.Password;
            account.Role = updatedAccount.Role ?? account.Role;
            account.status = updatedAccount.status;
            account.AccountStat = updatedAccount.AccountStat;
            account.SubscriptionId = updatedAccount.SubscriptionId != 0 ? updatedAccount.SubscriptionId : account.SubscriptionId;
            account.LastUpdated = DateTime.UtcNow;
            try
            {
                dbContext.Set<Account>().Update(account);
                await dbContext.SaveChangesAsync();
                return Ok(new { Message = "Account updated successfully", Account = account });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Error updating account", Error = ex.Message });
            }
        }
    }
}