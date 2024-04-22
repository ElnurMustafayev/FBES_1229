using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Json;
using System.Security.Claims;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;

namespace BlazorWasmApp.Providers;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly JwtSecurityTokenHandler jwtTokenHandler;
    private readonly ILocalStorageService localStorageService;

    public CustomAuthenticationStateProvider(
        ILocalStorageService localStorageService)
    {
            this.localStorageService = localStorageService;
        this.jwtTokenHandler = new JwtSecurityTokenHandler();
    }

    private async Task<ClaimsIdentity> GetClaimsIdentityAsync(string? jwt) {
        if(string.IsNullOrWhiteSpace(jwt)) {
            return new ClaimsIdentity();
        }

        var validationResult = await jwtTokenHandler.ValidateTokenAsync(
            jwt,
            new TokenValidationParameters()
            {
                ValidateAudience = true,
                ValidAudience = "AkshamBazari Inc.",

                ValidateIssuer = true,
                ValidIssuer = "identity.akshambazari.az",

                SignatureValidator = (token, validationParameters) => new JwtSecurityToken(token),

                ValidateLifetime = true,
                RequireExpirationTime = true,
                LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires > DateTime.UtcNow,
            }
        );

        if (validationResult.IsValid == false) {
            if(validationResult.Exception is SecurityTokenInvalidLifetimeException lifetimeException) {
                // get token again
                var httpClient = new HttpClient();

                var updateTokenResponse = await httpClient.PutAsJsonAsync("http://localhost:5295/api/Identity/UpdateToken", new { jwt });

                if (updateTokenResponse.IsSuccessStatusCode && updateTokenResponse.StatusCode == System.Net.HttpStatusCode.OK) {
                    var newJwt = await updateTokenResponse.Content.ReadAsStringAsync();

                    await this.localStorageService.SetItemAsStringAsync("jwt", newJwt);

                    var newToken = jwtTokenHandler.ReadJwtToken(newJwt);

                    return new ClaimsIdentity(newToken.Claims, "jwt");
                }
            }

            return new ClaimsIdentity();
        }

        var token = jwtTokenHandler.ReadJwtToken(jwt);

        return new ClaimsIdentity(token.Claims, "jwt");
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var jwt = await this.localStorageService.GetItemAsStringAsync("jwt");

        var claimsIdentity = await this.GetClaimsIdentityAsync(jwt);

        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

        var authenticationState = new AuthenticationState(claimsPrincipal);

        base.NotifyAuthenticationStateChanged(Task.FromResult(authenticationState));
        
        return authenticationState;
    }
}