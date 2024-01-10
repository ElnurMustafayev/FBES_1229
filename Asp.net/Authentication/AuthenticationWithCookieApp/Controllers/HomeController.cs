namespace AuthenticationWithCookieApp.Controllers;

using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Secret() {
        return Ok("Success");
    }
}