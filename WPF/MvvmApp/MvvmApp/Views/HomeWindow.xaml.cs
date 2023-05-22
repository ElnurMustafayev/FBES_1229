using MvvmApp.ViewModels;
using System.Windows.Controls;

namespace MvvmApp.Views {
    public partial class HomeWindow : UserControl {
        private readonly HomeViewModel viewModel = new HomeViewModel();

        public HomeWindow() {
            InitializeComponent();
        }
    }
}
