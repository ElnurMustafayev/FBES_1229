using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorWasmApp.Providers;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOlsiZGV2ZWxvcGVyIiwidXNlciJdLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiQm9iQGdtYWlsLmNvbSIsImV4cCI6MTcxMzM3NjIxMSwiaXNzIjoiRWxudXIiLCJhdWQiOiJTdGVwIElUIn0.8ofFpLsnpgJ670ibaODPoCRzqZ8eU1H8lJXONH068n0";

        var token = new JwtSecurityTokenHandler().ReadJwtToken(jwt);

        var claimsIdentity = new ClaimsIdentity(token.Claims, "jwt");

        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

        var authenticationState = new AuthenticationState(claimsPrincipal);

        base.NotifyAuthenticationStateChanged(Task.FromResult(authenticationState));
        
        return authenticationState;
    }
}