namespace BlogApp.ViewModels;

using BlogApp.Entities;
using BlogApp.Messager.Messages;
using BlogApp.Messager.Services.Base;
using BlogApp.Repositories.Base;
using BlogApp.Tools;
using BlogApp.ViewModels.Base;
using System;
using System.Windows;

public class LoginViewModel : ViewModelBase {
    private readonly IUsersRepository<User> usersRepository;
    private readonly IMessenger messenger;

    #region Props

    private string? login;
	public string? Login {
		get { return login; }
		set => base.PropertyChange(out login, value);
	}

    private string? password;
    public string? Password {
        get { return password; }
        set => base.PropertyChange(out password, value);
    }

    #endregion

    #region Commands

    private MyCommand? loginCommand;

    public MyCommand LoginCommand {
        get => this.loginCommand ??= new MyCommand(
            action: () => LoginUser(),
            predicate: () => !string.IsNullOrWhiteSpace(this.Login) && !string.IsNullOrWhiteSpace(this.Password));
        set => base.PropertyChange(out this.loginCommand, value);
    }

    #endregion

    public LoginViewModel(IUsersRepository<User> usersRepository, IMessenger messenger)
    {
        this.usersRepository = usersRepository;
        this.messenger = messenger;
    }

    void LoginUser()
    {
        try
        {
            var user = this.usersRepository.Login(this.Login, this.Password);

            this.Login = string.Empty;
            this.Password = string.Empty;

            this.messenger.Send(new SendLoginedUserMessage(user) { WhenLogined = DateTime.Now });
            this.messenger.Send(new NavigationMessage(typeof(BlogsViewModel)));
        }
        catch(Exception ex)
        {
            MessageBox.Show(
                messageBoxText: ex.Message,
                caption: "User login Error", 
                button: MessageBoxButton.OK, 
                icon: MessageBoxImage.Error);
        }
    }
}