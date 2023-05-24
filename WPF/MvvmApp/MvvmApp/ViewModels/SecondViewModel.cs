namespace MvvmApp.ViewModels;

using MvvmApp.Models.Messages;
using MvvmApp.Services.Base;
using MvvmApp.Tools;
using MvvmApp.ViewModels.Base;
using System.Windows.Media;

public class SecondViewModel : ViewModelBase {
    private readonly IMessenger messenger;

    private string message;
    public string Message {
        get => message;
        set => base.PropertyChange(out message, value);
    }

    private MyCommand navigationCommand;
    public MyCommand NavigationCommand {
        get => navigationCommand ??= new MyCommand(() => this.messenger.Send(new NavigationMessage(typeof(HomeViewModel))));
        set => base.PropertyChange(out navigationCommand, value);
    }

    public SecondViewModel(IMessenger messenger) {
        this.messenger = messenger;
    }
}