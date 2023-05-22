namespace MvvmApp;

using MvvmApp.ViewModels;
using MvvmApp.ViewModels.Base;
using System;
using System.Windows;

public partial class MainWindow : Window {
    private readonly MainViewModel viewModel = new MainViewModel();

    private HomeViewModel vm1 = new HomeViewModel();
    private SecondViewModel vm2 = new SecondViewModel();

    public MainWindow() {
        InitializeComponent();

        this.viewModel.ActiveViewModel = vm1;
        this.DataContext = this.viewModel;
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
        this.viewModel.ActiveViewModel = this.viewModel.ActiveViewModel is HomeViewModel ? vm2 : vm1;
    }
}
