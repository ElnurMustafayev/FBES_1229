namespace AspnetIdentityApp.Dtos;

using System.ComponentModel.DataAnnotations;

public class RegistrationDto
{
    [EmailAddress]
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}