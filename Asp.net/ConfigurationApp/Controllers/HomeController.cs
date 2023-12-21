using Microsoft.AspNetCore.Mvc;
using ConfigurationApp.Models;
using ConfigurationApp.Repositories.Base;
using Microsoft.Extensions.Options;

namespace ConfigurationApp.Controllers;

public class HomeController : Controller
{
    private readonly IUserRepository userRepository;
    private readonly Palette palette;

    public HomeController(IUserRepository userRepository, IOptions<Palette> paletteOptions)
    {
        this.userRepository = userRepository;
        this.palette = paletteOptions.Value;
    }

    public IActionResult Index()
    {
        this.userRepository.Test();

        System.Console.WriteLine($"CONTROLLER: {this.palette.front}");
        System.Console.WriteLine($"CONTROLLER: {this.palette.background}");

        return View();
    }
}
