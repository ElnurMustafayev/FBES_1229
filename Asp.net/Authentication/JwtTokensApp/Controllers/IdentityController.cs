namespace JwtTokensApp.Controllers;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using JwtTokensApp.Dtos;
using JwtTokensApp.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

[ApiController]
[Route("api/[controller]/[action]")]
public class IdentityController : ControllerBase
{
    private readonly JwtOptions jwtOptions;

    public IdentityController(IOptionsSnapshot<JwtOptions> JwtOptions)
    {
        this.jwtOptions = JwtOptions.Value;
    }

    [HttpPost]
    public string Login(LoginDto loginDto) {
        var keyInBytes = Encoding.UTF8.GetBytes(this.jwtOptions.Key);

        var securityKey = new SymmetricSecurityKey(keyInBytes);
        var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>() {
            new Claim(ClaimTypes.Name, loginDto.Login),
            new Claim(ClaimTypes.Role, "Admin")
        };

        var securityToken = new JwtSecurityToken(
            issuer: "Elnur",
            audience: "Step IT",
            claims,
            expires: DateTime.Now.AddMinutes(20),
            signingCredentials: signingCredentials
        );

        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        var jwt = jwtSecurityTokenHandler.WriteToken(securityToken);

        return jwt;
    }
}