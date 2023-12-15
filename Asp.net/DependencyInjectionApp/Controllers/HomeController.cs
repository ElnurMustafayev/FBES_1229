using DependencyInjectionApp.Repositories.Base;
using DependencyInjectionApp.Services.Base;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionApp.Controllers;

public class HomeController : Controller
{
    private readonly IUserRepository userRepository;
    private readonly UserServiceBase userService;

    public HomeController(IUserRepository userRepository, UserServiceBase userService)
    {
        System.Console.WriteLine(userRepository.GetHashCode());
        this.userRepository = userRepository;
        this.userService = userService;
    }

    public IActionResult Index()
    {
        System.Console.WriteLine($"Users Count: {userRepository.GetAllUsers().Count()}");
        return View();
    }
}
