#pragma warning disable CS8618

using System.Text.Json.Serialization;

namespace BlazorWasmApp.Models;

public class RefreshAccessTokens
{
    [JsonPropertyName("accessToken")]
    public string AccessToken { get; set; }
    
    [JsonPropertyName("refreshToken")]
    public string RefreshToken { get; set; }
}