using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NicknameTextbox_TextChanged(this.NicknameTextbox, null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Messenger(this.NicknameTextbox.Text).ShowDialog();
            this.Close();
        }

        private void NicknameTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textbox)
                this.LoginButton.IsEnabled = !string.IsNullOrEmpty(textbox.Text);
        }
    }
}
