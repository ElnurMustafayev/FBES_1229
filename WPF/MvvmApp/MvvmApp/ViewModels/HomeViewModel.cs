namespace MvvmApp.ViewModels;

using MvvmApp.Models.Messages;
using MvvmApp.Services.Base;
using MvvmApp.Tools;
using MvvmApp.ViewModels.Base;

public class HomeViewModel : ViewModelBase {
	private readonly IMessenger messenger;
	private string text;

	public string Text { get => this.text; set => base.PropertyChange(out this.text, value); }
	
	private MyCommand navigationCommand;
    public MyCommand NavigationCommand {
        get => navigationCommand ??= new MyCommand(() => this.messenger.Send(new NavigationMessage(typeof(SecondViewModel))));
        set => base.PropertyChange(out navigationCommand, value);
    }

    public HomeViewModel(IMessenger messenger) {
		this.messenger = messenger;

		messenger.Subscribe<TestMessage>((message) => {
			if (message is TestMessage testMessage) {
				this.Text = testMessage.Text ?? "...";
			}
		});
	}
}