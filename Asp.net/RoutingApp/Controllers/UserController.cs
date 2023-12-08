namespace RoutingApp.Controllers;

using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;

public class UserController : Controller
{
    public IActionResult Profile(int id)
    {
        var userProfileJson = System.IO.File.ReadAllText("Assets/user_profile.json");

        var jsonOptions = new JsonSerializerOptions() {
            PropertyNameCaseInsensitive = true,
        };
        var profiles = JsonSerializer.Deserialize<IEnumerable<UserProfile>>(userProfileJson, jsonOptions);

        var profile = profiles?.FirstOrDefault(p => p.Id == id);

        if(profile is null)
            return base.NotFound();

        return View(profile);
    }
}