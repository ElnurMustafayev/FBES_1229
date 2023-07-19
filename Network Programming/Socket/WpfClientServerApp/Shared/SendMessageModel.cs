namespace Shared;

public class SendMessageModel
{
    public string Nickname { get; set; }
    public string Message { get; set; }
    public bool IsSpecial { get; set; }

    public SendMessageModel(string nickname, string message)
    {
        Nickname = nickname;
        Message = message;
    }

    public SendMessageModel()
    {

    }
}