using System.ComponentModel.DataAnnotations;

namespace AspnetIdentityApp.Dtos;

public class LoginDto
{
    public string Login { get; set; }
    
    public string Password { get; set; }
}