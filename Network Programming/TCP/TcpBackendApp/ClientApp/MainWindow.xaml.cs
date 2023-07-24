﻿using ClientApp.Views;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e) {
            var view = new LoginWindow();

            this.Hide();
            view.ShowDialog();
            this.ShowDialog();
        }

        private void Registration_Click(object sender, RoutedEventArgs e) {
            var view = new RegistrationWindow();

            this.Hide();
            view.ShowDialog();
            this.ShowDialog();
        }
    }
}
