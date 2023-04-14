namespace MediatorApp.ViewModels;

public abstract class ViewModelBase {
	protected readonly Messenger messenger;

	public ViewModelBase(Messenger messenger) {
		this.messenger = messenger;
	}
}