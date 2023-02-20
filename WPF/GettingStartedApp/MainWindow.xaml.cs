using System;
using System.Windows;

namespace GettingStartedApp {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            //this.MyTextBox.TextChanged += MyTextBox_TextChanged;
        }

        //private void MyTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) {
        //    this.MyTextBox.IsReadOnly = this.MyTextBox.Text.Length >= 25;
        //}

        private void MyButton_Click(object sender, RoutedEventArgs e) {
            this.ResizeMode = ResizeMode.NoResize;
        }

        //private void MyButton_Click(object sender, RoutedEventArgs e) {
        //    //Console.WriteLine("Button clicked!");
        //    this.MyButton.IsEnabled = false;
        //}
    }
}
