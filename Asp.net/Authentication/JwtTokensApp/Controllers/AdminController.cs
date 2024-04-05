using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtTokensApp.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("api/[controller]/[action]")]
public class AdminController : ControllerBase
{
    [HttpPost]
    public IActionResult SayHiToAdmin() {
        return Ok("Admin: Hi!");
    }
}