namespace BlogApp.ViewModels;

using BlogApp.ViewModels.Base;

public class MainViewModel : ViewModelBase {

	private ViewModelBase? activeViewModel;

	public ViewModelBase? ActiveViewModel {
		get { return activeViewModel; }
		set { this.PropertyChange(out activeViewModel, value); }
	}
}
