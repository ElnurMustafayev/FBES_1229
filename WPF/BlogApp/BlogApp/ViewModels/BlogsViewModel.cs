namespace BlogApp.ViewModels;

using BlogApp.Entities;
using BlogApp.Messager.Messages;
using BlogApp.Messager.Messages.Base;
using BlogApp.Messager.Services.Base;
using BlogApp.Tools;
using BlogApp.ViewModels.Base;
using System;

public class BlogsViewModel : ViewModelBase
{
    private User? currentUser;
    private readonly IMessenger messenger;

    public User? CurrentUser
    {
        get { return currentUser; }
        set => base.PropertyChange(out currentUser, value);
    }


    private MyCommand? logoutCommand;

    public MyCommand LogoutCommand
    {
        get => this.logoutCommand ??= new MyCommand(
            action: () =>
            {
                this.CurrentUser = null;
                this.messenger.Send(new NavigationMessage(typeof(LoginViewModel)));
            },
            predicate: () => true);
        set => base.PropertyChange(out this.logoutCommand, value);
    }



    public BlogsViewModel(IMessenger messenger)
    {
        this.messenger = messenger;

        this.messenger.Subscribe<SendLoginedUserMessage>(obj =>
        {
            if (obj is SendLoginedUserMessage message)
            {
                this.CurrentUser = message.LoginedUser;
            }
        });
    }
}