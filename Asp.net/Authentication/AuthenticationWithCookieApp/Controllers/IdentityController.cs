namespace AuthenticationWithCookieApp.Controllers;

using System.Data.SqlClient;
using AuthenticationWithCookieApp.Dtos;
using AuthenticationWithCookieApp.Models;
using Dapper;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

public class IdentityController : Controller
{
    private const string ConnectionString = "Server=localhost;Database=AuthDb;User Id=sa;Password=Admin9264!!;";
    private readonly IDataProtector dataProtector;

    public IdentityController(IDataProtectionProvider dataProtectionProvider)
    {
        this.dataProtector = dataProtectionProvider.CreateProtector("TEST");
    }

    public string Hash() {
        return this.dataProtector.Protect("ELNUR");
    }

    public string Dehash(string hash) {
        return this.dataProtector.Unprotect(hash);
    }

    [HttpGet]
    public IActionResult Login() {
        return base.View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginDto loginDto) {
        //base.HttpContext.Response.Headers.Add("Authorize", $"{loginDto.Login}");

        using var connection = new SqlConnection(ConnectionString);
        var foundUser = await connection.QueryFirstOrDefaultAsync<User>(
            sql: @"select *
from Users
where Login = @login and Password = @password",
            param: new {
                login = loginDto.Login,
                password = loginDto.Password,
            }
        );

        if(foundUser is not null) {
            var userHash = this.dataProtector.Protect(foundUser.Id.ToString());

            base.HttpContext.Response.Cookies.Append("Authorize", userHash);
            return Ok();
        }
        else {
            return BadRequest("Incorrect login or password!");
        }
    }
}