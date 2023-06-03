namespace BlogApp.ViewModels;

using BlogApp.Messager.Messages;
using BlogApp.Messager.Services.Base;
using BlogApp.ViewModels.Base;

public class MainViewModel : ViewModelBase {

	private ViewModelBase? activeViewModel;
	private readonly IMessenger messenger;

	public ViewModelBase? ActiveViewModel {
		get { return activeViewModel; }
		set { this.PropertyChange(out activeViewModel, value); }
	}

	public MainViewModel(IMessenger messenger)
	{
		this.messenger = messenger;

		this.messenger.Subscribe<NavigationMessage>((message) =>
		{
			if (message is NavigationMessage navigationMessage)
			{
                var serviceObj = App.ServiceContainer.GetInstance(navigationMessage.NavigateTo);

				if(serviceObj is ViewModelBase vm)
					this.ActiveViewModel = vm;
            }
		});
    }
}
