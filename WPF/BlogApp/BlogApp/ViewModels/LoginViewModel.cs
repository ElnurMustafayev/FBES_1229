namespace BlogApp.ViewModels;

using BlogApp.Tools;
using BlogApp.ViewModels.Base;
using System.Windows;

public class LoginViewModel : ViewModelBase {
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
            action: () => MessageBox.Show("Test"), 
            predicate: () => !string.IsNullOrWhiteSpace(this.Login) && !string.IsNullOrWhiteSpace(this.Password));
        set => base.PropertyChange(out this.loginCommand, value);
    }

    #endregion
}