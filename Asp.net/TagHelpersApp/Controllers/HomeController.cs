using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TagHelpersApp.Models;

namespace TagHelpersApp.Controllers;

public class HomeController : Controller
{
    [Route("/myrouting/[action]/123")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Test(int? num)
    {
        return Ok(num * num);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
