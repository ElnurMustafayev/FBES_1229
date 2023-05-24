namespace MvvmApp.ViewModels;

using MvvmApp.Models.Messages;
using MvvmApp.Services.Base;
using MvvmApp.ViewModels.Base;
using System.Threading;

public class MainViewModel : ViewModelBase {
    private int number;
	private ViewModelBase activeViewModel;
	private readonly IMessenger messenger;

	public int Number { get => number; set => base.PropertyChange(out this.number, value); }

	public ViewModelBase ActiveViewModel {
		get { return activeViewModel; }
		set { base.PropertyChange(out this.activeViewModel, value); }
	}

	public MainViewModel(IMessenger messenger) {
		this.messenger = messenger;

		this.messenger.Subscribe<NavigationMessage>((message) => {
			if (message is NavigationMessage navigationMessage) {
				var viewModelObj = App.ServiceContainer.GetInstance(navigationMessage.DestinationViewModelType);
				if (viewModelObj is ViewModelBase viewModel) {
					this.ActiveViewModel = viewModel;
				}
			}
		});
    }
}