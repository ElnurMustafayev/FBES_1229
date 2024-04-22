#pragma warning disable CS8618

namespace JwtTokensApp.Dtos;

public class UpdateTokenDto
{
    public string AccessToken { get; set; }
    public Guid RefreshToken { get; set; }
}