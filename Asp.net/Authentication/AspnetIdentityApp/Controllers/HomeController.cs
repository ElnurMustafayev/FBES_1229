using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetIdentityApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace AspnetIdentityApp.Controllers;

// [Authorize(Roles = "Test")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }

    // Admin or Moderator
    [Authorize(Roles = "Admin, Moderator")]


    // Admin and Moderator
    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Moderator")]
    public IActionResult Secret() {
        return base.Ok();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
