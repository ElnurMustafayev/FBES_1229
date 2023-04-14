namespace MediatorApp.Messages.Base;

public class AfterSuccessLoginMessage : IMessage {
    public string Login { get; set; }
    public string Password { get; set; }
    public User User { get; set; }
}