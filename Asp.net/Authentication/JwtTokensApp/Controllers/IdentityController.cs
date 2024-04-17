namespace JwtTokensApp.Controllers;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using JwtTokensApp.Dtos;
using JwtTokensApp.Models;
using JwtTokensApp.Options;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

[ApiController]
[Route("api/[controller]/[action]")]
public class IdentityController : ControllerBase
{
    private readonly JwtOptions jwtOptions;
    private readonly SignInManager<IdentityUser> signInManager;
    private readonly UserManager<IdentityUser> userManager;

    public IdentityController(
        IOptionsSnapshot<JwtOptions> jwtOptions,
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager)
    {
        this.signInManager = signInManager;
        this.userManager = userManager;
        this.jwtOptions = jwtOptions.Value;
    }

    [HttpPost]
    public async Task<IActionResult> LoginAsync(LoginDto loginDto) {
        var user = await this.userManager.FindByEmailAsync(loginDto.Login);

        if (user is null) {
            return base.BadRequest(new {
                Message = "Incorrect login or password",
            });
        }
        
        var signInResult = await this.signInManager.PasswordSignInAsync(user, loginDto.Password, false, true);
        
        if (signInResult.IsLockedOut) {
            return base.BadRequest(new {
                Message = "Account was locked",
            });
        }

        if (signInResult.Succeeded == false) {
            return base.BadRequest(new {
                Message = "Incorrect login or password",
            });
        }

        var roles = await userManager.GetRolesAsync(user);

        var claims = roles
            .Select(role => new Claim(ClaimTypes.Role, role))
            .Append(new Claim(ClaimTypes.Name, loginDto.Login));

        var securityKey = new SymmetricSecurityKey(this.jwtOptions.KeyInBytes);
        var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var securityToken = new JwtSecurityToken(
            issuer: this.jwtOptions.Issuers.First(),
            audience: this.jwtOptions.Audience,
            claims,
            expires: DateTime.Now.AddMinutes(this.jwtOptions.LifetimeInMinutes),
            signingCredentials: signingCredentials
        );

        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        var jwt = jwtSecurityTokenHandler.WriteToken(securityToken);

        return base.Ok(jwt);
    }

    [HttpPost]
    public async Task<IActionResult> RegistrationAsync(RegistrationDto registrationDto) {
        var newUser = new IdentityUser {
            UserName = registrationDto.Email,
            Email = registrationDto.Email,
        };
        
        var signUpResult = await this.userManager.CreateAsync(newUser, registrationDto.Password);

        if (signUpResult.Succeeded == false) {
            return base.BadRequest(signUpResult.Errors.Select(error => error.Description));
        }

        var roleResult = await userManager.AddToRoleAsync(newUser, DefaultRoles.User);

        return base.Created(base.HttpContext.Request.GetDisplayUrl(), null);
    }
}