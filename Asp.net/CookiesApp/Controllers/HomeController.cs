using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace CookiesApp.Controllers;

[Route("[controller]/[action]")]
public class HomeController : ControllerBase
{
    public IActionResult ShowHeaders() {
        StringBuilder sb = new StringBuilder();
        foreach (var header in base.HttpContext.Request.Headers)
        {
            sb.Append(header.Key + "\n");
        } 

        return Ok(sb.ToString());
    }

    [HttpGet("/[controller]/[action]/{key}")]
    public IActionResult GetCookie(string key) {
        var foundCookieValue = this.Request.Cookies[key];

        if(foundCookieValue is null) {
            return NotFound();
        }

        return Ok(foundCookieValue);
    }

    public IActionResult AddCookie(string key, string value) {
        //base.HttpContext.Response.Headers.Add("Set-Cookie", "manual=12345");

        base.HttpContext.Response.Cookies.Append(key, value,
         options: new CookieOptions {
            Expires = DateTimeOffset.Now.AddDays(1),
         });
         
        return Ok();
    }
}