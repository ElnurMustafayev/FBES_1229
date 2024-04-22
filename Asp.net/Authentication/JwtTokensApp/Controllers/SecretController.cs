using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using JwtTokensApp.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace JwtTokensApp.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class SecretController : ControllerBase
{
    private readonly JwtOptions jwtOptions;

    public SecretController(IOptionsSnapshot<JwtOptions> JwtOptions)
    {
        this.jwtOptions = JwtOptions.Value;
    }

    [HttpGet("~/api/old/[controller]")]
    public async Task<IActionResult> GetSecretsOld([FromHeader] string jwt)
    {
        var jwtHeaderValues = base.HttpContext.Request.Headers["jwt"];

        if (jwtHeaderValues.Any() == false)
        {
            return base.Unauthorized();
        }

        var jwtHeaderStr = jwtHeaderValues.First();

        var handler = new JwtSecurityTokenHandler();

        var validationResult = await handler.ValidateTokenAsync(
            jwtHeaderStr,
            new TokenValidationParameters()
            {
                IssuerSigningKey = new SymmetricSecurityKey(this.jwtOptions.KeyInBytes),

                ValidateAudience = true,
                ValidAudience = this.jwtOptions.Audience,

                ValidateIssuer = true,
                ValidIssuers = this.jwtOptions.Issuers,
            }
        );

        if (validationResult.IsValid == false)
        {
            return base.Forbid(validationResult.Exception.Message);
        }

        var nameClaim = base.HttpContext.User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email);
        
        return Ok($"Hi, {nameClaim?.Value ?? "Unknown"}!");
    }


    [Authorize]
    [HttpGet("~/api/[controller]")]
    public IActionResult GetSecrets()
    {
        var nameClaim = base.HttpContext.User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email);
        
        return Ok($"Hi, {nameClaim?.Value ?? "Unknown"}!");
    }

    [Authorize]
    [HttpGet]
    public IActionResult Claims()
    {
        var claimsTxt = string.Join(
            "\n", 
            base.HttpContext.User.Claims.Select(claim => $"{claim.Type}: {claim.Value}")
        );
        
        return Ok(claimsTxt);
    }
}