namespace AuthenticationWithCookieApp.Controllers;

using System.Data.SqlClient;
using AuthenticationWithCookieApp.Dtos;
using AuthenticationWithCookieApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

public class IdentityController : Controller
{
    private const string ConnectionString = "Server=localhost;Database=AuthDb;User Id=sa;Password=Admin9264!!;";

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
            base.HttpContext.Response.Cookies.Append("Authorize", $"{loginDto.Login}");
            return Ok();
        }
        else {
            return BadRequest("Incorrect login or password!");
        }
    }
}