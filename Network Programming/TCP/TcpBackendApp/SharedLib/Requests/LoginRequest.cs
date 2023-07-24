namespace SharedLib.Requests;

public class LoginRequest {
    public string Login { get; set; }
    public string Password { get; set; }

    public LoginRequest(string login, string password) {
        this.Login = login;
        this.Password = password;
    }

    public LoginRequest() {

    }
}