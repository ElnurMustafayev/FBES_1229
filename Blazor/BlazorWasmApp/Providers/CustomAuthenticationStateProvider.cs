using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorWasmApp.Providers;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    public static bool IsLogined { get; set; } = false;

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        //var jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoic3RyaW5nIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiVXNlciIsImV4cCI6MTcxMjU5OTcyNiwiaXNzIjoiRWxudXIiLCJhdWQiOiJTdGVwIElUIn0.To_mpeKUvFn5jaqx6pAhIp_hxlbsP6X84D65XVmK1-s";

        //var token = new JwtSecurityTokenHandler().ReadJwtToken(jwt);

        var claims = new List<Claim> {
            new(ClaimTypes.Role, "user"),
            new(ClaimTypes.Role, "admin"),
            new(ClaimTypes.Name, "Bob"),
        };

        var claimsIdentity = IsLogined 
            ? new ClaimsIdentity(claims, "jwt")
            : new ClaimsIdentity();

        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

        var authenticationState = new AuthenticationState(claimsPrincipal);

        base.NotifyAuthenticationStateChanged(Task.FromResult(authenticationState));
        
        return authenticationState;
    }
}