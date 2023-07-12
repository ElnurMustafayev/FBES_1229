namespace MyClassLib.Models;

public class User
{
    public string? Login { get; set; }
    public string? Password { get; set; }

    public override string ToString() => $"Login: {Login} Password: {Password}";
}