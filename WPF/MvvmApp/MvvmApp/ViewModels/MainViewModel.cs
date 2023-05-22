namespace MvvmApp.ViewModels;

using MvvmApp.ViewModels.Base;

public class MainViewModel : ViewModelBase {
    private int number;
	private ViewModelBase activeViewModel;



    public int Number { get => number; set => base.PropertyChange(out this.number, value); }

	public ViewModelBase ActiveViewModel {
		get { return activeViewModel; }
		set { base.PropertyChange(out this.activeViewModel, value); }
	}
}