using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MvcEfApp.Data;
using MvcEfApp.Models;

namespace MvcEfApp.Controllers;

public class HomeController : Controller
{
    private readonly MyDbContext dbContext;

    public HomeController(MyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task<IActionResult> Index()
    {
        var newUser = new User
        {
            FirstName = "Bob",
            LastName = "Marley",
            BirthDate = new DateTime(1920, 12, 12),
        };

        await this.dbContext.Users.AddAsync(newUser);
        await this.dbContext.SaveChangesAsync();

        return View();
    }
}
