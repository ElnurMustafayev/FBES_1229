using SharedLib.Requests.Base;
using SharedLib.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClientApp.Views {
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window {
        public RegistrationWindow() {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e) {
            var mail = this.MailTextbox.Text;
            var password = this.PasswordTextbox.Text;
            var gender = this.GenderCombobox.Text;

            Task.Run(async () => {
                var tcpClient = new TcpClient();

                await tcpClient.ConnectAsync(
                    address: IPAddress.Parse("127.0.0.1"),
                    port: 8080);

                var writer = new StreamWriter(tcpClient.GetStream());


                var request = new Request<RegistrationRequest>(requestType: nameof(RegistrationRequest)) {
                    Data = new RegistrationRequest() {
                        Mail = mail,
                        Gender = gender,
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
