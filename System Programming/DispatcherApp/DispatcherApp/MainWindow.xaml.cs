using System;
using System.Threading;
using System.Windows;
using System.Data.SqlClient;
using Dapper;
using Microsoft.VisualBasic;

namespace DispatcherApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            new Thread(() => {
                Timer timer = new Timer(
                    callback: (state) => {
                        Dispatcher.Invoke(() => {
                            this.MyProgressBar.Value++;
                        });
                    },
                    state: null,
                    dueTime: 0,
                    period: 1000
                );
            }).Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            new Thread(() => {
                string connectionString = $"Server=localhost;Database=MyAppDb;User Id=admin;Password=admin;";

                var connection = new SqlConnection(connectionString);

                var result = connection.ExecuteScalar<string>("select max(u.[Name]) from [Users] u");
                Thread.Sleep(2000);
                Dispatcher.Invoke(() => {
                    this.MyTextBox.Text = Guid.NewGuid().ToString();
                });
            }).Start();
        }
    }
}
