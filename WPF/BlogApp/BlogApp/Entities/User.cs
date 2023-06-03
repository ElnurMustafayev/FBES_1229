using System;
using System.Linq;

namespace BlogApp.Entities;

public class User {
    public int Id { get; set; }

    public string Login { get; set; }
    public string Password { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? BirthDate { get; set; }

    public User(string login, string password)
    {
        Login = login;
        Password = password;
    }

    private User()
    {
        this.Login = "Unknown";
        this.Password = "Unknown";
    }

    public override string ToString()
    {
        var maskedPasswordChars = this.Password.Select((symbol, index) => (index < this.Password.Length / 2) ? symbol : '*');
        string maskedPasswordString = string.Join("", maskedPasswordChars);
        return $@"#[{this.Id}] {this.Login} {maskedPasswordString}";
    }
}
