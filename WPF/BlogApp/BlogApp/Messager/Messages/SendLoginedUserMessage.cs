namespace BlogApp.Messager.Messages;

using BlogApp.Entities;
using BlogApp.Messager.Messages.Base;
using System;

public class SendLoginedUserMessage : IMessage
{
    public User LoginedUser { get; set; }
    public DateTime? WhenLogined { get; set; }

    public SendLoginedUserMessage(User loginedUser) {
        this.LoginedUser = loginedUser;
    }
}