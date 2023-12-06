namespace RoutingApp.Controllers;

using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // var namesJson = System.IO.File.ReadAllText("Assets/names.json");
        // var names = JsonSerializer.Deserialize<IEnumerable<string>>(namesJson);

        // base.ViewBag.Names = names;
        // base.ViewBag.IsDevelopment = true;

        // base.ViewData["names"] = names;
        // base.ViewData["isDevelopment"] = true;





        var usersJson = System.IO.File.ReadAllText("Assets/users.json");
        var users = JsonSerializer.Deserialize<IEnumerable<User>>(usersJson);
        
        // base.ViewBag.Users = users;

        return base.View(users);
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
