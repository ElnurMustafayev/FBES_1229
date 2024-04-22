#pragma warning disable CS8618

namespace JwtTokensApp.Models;

public class RefreshToken
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public Guid Token { get; set; }
}