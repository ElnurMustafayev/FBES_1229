namespace AuthenticationWithCookieApp.Controllers;

using System.Data.SqlClient;
using AuthenticationWithCookieApp.Models;
using AuthenticationWithCookieApp.Services;
using Dapper;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private const string ConnectionString = "Server=localhost;Database=AuthDb;User Id=sa;Password=Admin9264!!;";
    private readonly IDataProtector dataProtector;
    private readonly IdentityService identityService;

    public HomeController(IDataProtectionProvider dataProtectionProvider, IdentityService identityService)
    {
        this.dataProtector = dataProtectionProvider.CreateProtector("TEST");
        this.identityService = identityService;
    }

    // private endpoint
    public IActionResult Index() {
        // 1. Check cookie exist
        var authorizeCookie = base.HttpContext.Request.Cookies["Authorize"];

        if(string.IsNullOrWhiteSpace(authorizeCookie)) {
            return base.Unauthorized();
        }

        string? userHashValue = null;

        // 2. Unprotect cookie exist
        try {
            userHashValue = this.dataProtector.Unprotect(authorizeCookie);
        }
        catch(Exception ex) {
            return base.BadRequest(ex.Message);
            //return base.Unauthorized();
        }

        return base.Ok(userHashValue);
    }

    //public IActionResult GetUserInfo(long userId) {}

    public async Task<IActionResult> GetMyInfo() {
        long userId = 0;
        var actionResult = this.identityService.GetUserId(ref userId, base.HttpContext);

        if(actionResult is not OkResult && actionResult is not OkObjectResult) {
            return actionResult;
        }

        using var connection = new SqlConnection(ConnectionString);
        var foundUser = await connection.QueryFirstOrDefaultAsync<User>(
                sql: @"select * from Users where Id = @id",
                param: new {
                    id = userId,
                }
            );

        if(foundUser is null) {
            return base.NotFound($"User with id '{userId}' not found");
        }

        return base.Ok($"Hello, {foundUser.Login}!");
    }
}