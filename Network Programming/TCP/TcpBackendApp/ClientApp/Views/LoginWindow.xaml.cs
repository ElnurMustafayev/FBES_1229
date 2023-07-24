using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SharedLib.Requests.Base;
using SharedLib.Requests;
using System.Text.Json;

namespace ClientApp.Views {
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window {
        public LoginWindow() {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e) {

            var login = this.LoginTextbox.Text;
            var password = this.PasswordTextbox.Text;


            Task.Run(async () => {
                var tcpClient = new TcpClient();

                await tcpClient.ConnectAsync(
                    address: IPAddress.Parse("127.0.0.1"),
                    port: 8080);

                var writer = new StreamWriter(tcpClient.GetStream());


                var request = new Request<LoginRequest>(requestType: nameof(LoginRequest)) {
                    Data = new LoginRequest() {
                        Login = login,
                        Password = password,
                    },
                };

                var requestJson = JsonSerializer.Serialize(request);

                await writer.WriteLineAsync(requestJson);
                await writer.FlushAsync();
            }).Wait();

            this.Close();
        }
    }
}
