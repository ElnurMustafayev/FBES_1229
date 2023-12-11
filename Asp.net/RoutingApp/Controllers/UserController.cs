namespace RoutingApp.Controllers;

using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using RoutingApp.Dtos;
using RoutingApp.Models;

public class UserController : Controller
{
    // [HttpGet]
    // [HttpPost]
    // [AcceptVerbs("GET", "POST")]

    [HttpGet]
    public IActionResult Test([FromQuery]TestDto dto) {
        System.Console.WriteLine(dto.One);

        return Ok();
    }

    [Route("[controller]/{id:int}/[action]")]
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

    public IActionResult GetLink() {

        var generatedLink = base.Url.Link("MyCustomTestRouting", new { id = 123 });

        return base.Ok(generatedLink);
    }

    // [Route("[controller]/[action]/{name}")]
    // [Route("[controller]/[action]")]
    // public IActionResult Profile(string name)
    // {
    //     var userProfileJson = System.IO.File.ReadAllText("Assets/user_profile.json");

    //     var jsonOptions = new JsonSerializerOptions() {
    //         PropertyNameCaseInsensitive = true,
    //     };
    //     var profiles = JsonSerializer.Deserialize<IEnumerable<UserProfile>>(userProfileJson, jsonOptions);

    //     var profile = profiles?.FirstOrDefault(p => p.Firstname == name);

    //     if(profile is null)
    //         return base.NotFound();

    //     return View(profile);
    // }
}