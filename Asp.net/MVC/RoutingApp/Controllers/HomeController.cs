namespace RoutingApp.Controllers;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return base.View();
    }

    public IActionResult Privacy()
    {
        return base.View();
    }

    public IActionResult Test() {
        return base.View("RandomName");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
