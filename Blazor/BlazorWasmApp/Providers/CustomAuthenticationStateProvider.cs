using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text.Json;
using Blazored.LocalStorage;
using BlazorWasmApp.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;

namespace BlazorWasmApp.Providers;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly JwtSecurityTokenHandler jwtTokenHandler;
    private readonly ILocalStorageService localStorageService;
    private readonly IHttpClientFactory httpClientFactory;

    public CustomAuthenticationStateProvider(
        ILocalStorageService localStorageService,
        IHttpClientFactory httpClientFactory)
    {
        this.localStorageService = localStorageService;
        this.httpClientFactory = httpClientFactory;
        this.jwtTokenHandler = new JwtSecurityTokenHandler();
    }

    private async Task<ClaimsIdentity> GetClaimsIdentityAsync(string? accessToken, string? refreshToken) {
        if(string.IsNullOrWhiteSpace(accessToken) || string.IsNullOrWhiteSpace(refreshToken)) {
            return new ClaimsIdentity();
        }

        var validationResult = await jwtTokenHandler.ValidateTokenAsync(
            accessToken,
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
                // update token
                var httpClient = httpClientFactory.CreateClient("identity");

                var updateTokensResponse = await httpClient.PutAsJsonAsync(
                    "api/Identity/UpdateToken", 
                    new {
                        accessToken,
                        refreshToken
                    }
                );

                if (updateTokensResponse.IsSuccessStatusCode && updateTokensResponse.StatusCode == System.Net.HttpStatusCode.OK) {
                    var updateTokensResponseJson = await updateTokensResponse.Content.ReadAsStringAsync();
                    var newRefreshAccessTokens = JsonSerializer.Deserialize<RefreshAccessTokens>(updateTokensResponseJson)!;
                    
                    await this.localStorageService.SetItemAsStringAsync("accessToken", newRefreshAccessTokens.AccessToken);
                    await this.localStorageService.SetItemAsStringAsync("refreshToken", newRefreshAccessTokens.RefreshToken);

                    var newToken = jwtTokenHandler.ReadJwtToken(newRefreshAccessTokens.AccessToken);

                    return new ClaimsIdentity(newToken.Claims, "jwt");
                }
            }

            return new ClaimsIdentity();
        }

        var token = jwtTokenHandler.ReadJwtToken(accessToken);

        return new ClaimsIdentity(token.Claims, "jwt");
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var accessToken = await this.localStorageService.GetItemAsStringAsync("accessToken");
        var refreshToken = await this.localStorageService.GetItemAsStringAsync("refreshToken");

        var claimsIdentity = await this.GetClaimsIdentityAsync(accessToken, refreshToken);

        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

        var authenticationState = new AuthenticationState(claimsPrincipal);

        base.NotifyAuthenticationStateChanged(Task.FromResult(authenticationState));
        
        return authenticationState;
    }
}