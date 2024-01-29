// TODO: 
// login page, endpoint
// registration page, endpoint
// AddRole, RemoveRole

using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using AspnetIdentityApp.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspnetIdentityApp.Controllers;

public class IdentityController : Controller
{
    private readonly UserManager<IdentityUser> userManager;
    private readonly RoleManager<IdentityRole> roleManager;
    private readonly SignInManager<IdentityUser> signInManager;

    public IdentityController(UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager,
        SignInManager<IdentityUser> signInManager)
    {
        this.userManager = userManager;
        this.roleManager = roleManager;
        this.signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Login() {
        return base.View();
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromForm]LoginDto dto) {
        var user = await this.userManager.FindByEmailAsync(dto.Login);

        if(user == null) {
            return base.BadRequest();
        }


        // user, pwd, remind me, lockEnabled
        var result = await this.signInManager.PasswordSignInAsync(user, dto.Password, true, true);

        if(result.Succeeded == false)
            return base.BadRequest();

        return base.Ok();
    }

    [HttpGet]
    public IActionResult Registration() {
        return base.View();
    }

    [HttpPost]
    public async Task<IActionResult> Registration([FromForm]RegistrationDto dto) {
        var newUser = new IdentityUser {
            Email = dto.Email,
            UserName = dto.Username,
        };
        var result = await this.userManager.CreateAsync(newUser, dto.Password);

        if(result.Succeeded == false) {
            foreach (var error in result.Errors) {
                base.ModelState.AddModelError(error.Code, error.Description);
            }

            return base.View("Registration");
        }

        if(dto.Username.Contains("admin")) {
            var role = new IdentityRole {Name = "Admin"};
            await roleManager.CreateAsync(role);

            await userManager.AddToRoleAsync(newUser, role.Name);
        }

        var locationLink = base.Url.Action(action: "Login", controller: "Identity") ?? "/Identity/Login";

        return base.Created(locationLink, newUser);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Logout([FromForm]LoginDto dto) {
        await this.signInManager.SignOutAsync();
        return base.Ok();
    }
}