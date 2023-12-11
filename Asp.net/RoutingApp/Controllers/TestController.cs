namespace RoutingApp.Controllers;

using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;

[Route("api/[controller]/[action]")]
public class TestController : Controller
{
    // [Route("api/HelloWorld1")]
    // [Route("api/[action]/helloworld/[action][controller]")]
    // [ActionName("Salam")]
    // [Route("api/[action]")]       // inheriting
    // [Route("/api/[action]")]      // rewrite
    // [Route("~/api/[action]")]     // rewrite
    // [NonAction]

    [Route("Test/[action]/{id}", Name = "MyCustomTestRouting", Order = 2)]
    public IActionResult GetUser(int id)
    {
        var user = new User()
        {
            Name = "Bob",
            Surname = "Marley",
        };

        return base.Ok(user);
    }

    // [ActionName("MyTestMethod")]
    // public IActionResult Test()
    // {
    //     return base.Ok(new { Id = 123, Success = false });
    // }
}