namespace RoutingApp.Controllers;

using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using RoutingApp.Dtos;
using RoutingApp.Models;

public class HomeController : Controller
{
    public HomeController()
    {
        System.Console.WriteLine("HomeController created!");
    }

    public IActionResult MyMethod(int? id, string? name = "unknown") {
        return Ok(new {
            id, name
        });
    }

    [HttpGet]
    public IActionResult Login() {
        return base.View();
    }
    
    [HttpPost]
    public IActionResult Login(LoginDto loginDto) {
        System.Console.WriteLine($"{loginDto.Login} {loginDto.Password}");

        //return View("Index");
        return RedirectToAction("Index");
        //return this.Index();

        //return Ok($"POST Login OK by '{loginDto.Login}'!");
    }



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
