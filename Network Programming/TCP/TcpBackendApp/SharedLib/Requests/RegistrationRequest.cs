namespace SharedLib.Requests;

public class RegistrationRequest {
    public string Mail { get; set; }
    public string Password { get; set; }
    public string Gender { get; set; }

    public RegistrationRequest(string mail, string password, string gender) {
        Mail = mail;
        Password = password;
        Gender = gender;
    }

    public RegistrationRequest() {

    }
}