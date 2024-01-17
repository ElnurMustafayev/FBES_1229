using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AuthorizationApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace AuthorizationApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Authorize(Policy = "Administrators")]
    public IActionResult Secret()
    {
        // if(base.User.Claims.Any(c => c.Type == "admin") == false) {
        //     return base.Forbid();
        // }

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
