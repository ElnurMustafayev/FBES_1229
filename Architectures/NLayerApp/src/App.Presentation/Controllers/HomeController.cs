#pragma warning disable IDE0290

namespace App.Presentation.Controllers;

using App.Core.Repositories;
using App.Core.Services;
// using App.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly IUserRepository userRepository;
    private readonly IUserService userService;

    public HomeController(IUserRepository userRepository, IUserService userService)
    {
        this.userRepository = userRepository;
        this.userService = userService;
    }

    public IActionResult GetUserFullname()
    {
        var user = this.userRepository.GetUser();

        return Ok($"{user.Firstname} {user.Lastname}");
    }

    public IActionResult AUUU(){
        return Ok(this.userService.IsAnyUser());
    }
}
