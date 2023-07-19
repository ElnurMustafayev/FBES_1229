using Shared;
using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for Messenger.xaml
    /// </summary>
    public partial class Messenger : Window
    {
        private Socket? serverSocket;
        public string Nickname { get; set; }

        public Messenger()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public Messenger(string nickname) : this()
        {
            this.Nickname = nickname;
        }

        protected override void OnContentRendered(EventArgs e)
        {
            Task.Run(async () =>
            {
                try
                {
                    this.serverSocket = new Socket(
                        AddressFamily.InterNetwork,
                        SocketType.Stream,
                        ProtocolType.Tcp);

                    const string serverAddress = "127.0.0.1";
                    const short port = 8080;
                    await serverSocket.ConnectAsync(serverAddress, port);

                    Dispatcher.Invoke(() =>
                    {
                        this.NicknameTextblock.Background = Brushes.Green;
                    });

                    SendMessage(
                        serverSocket: this.serverSocket, 
                        model: new SendMessageModel(this.Nickname, string.Empty) { 
                            IsSpecial = true 
                        });

                    ThreadPool.QueueUserWorkItem(async (state) => {
                        byte[] buffer = new byte[1024];
                        while (true)
                        {
                            try
                            {
                                int messageSize = await serverSocket.ReceiveAsync(buffer, SocketFlags.None);
                                string messageFromServerJson = Encoding.UTF8.GetString(buffer, 0, messageSize);
                                var messageModel = JsonSerializer.Deserialize<SendMessageModel>(messageFromServerJson);

                                Dispatcher.Invoke(() =>
                                {
                                    this.MessagesListBox.Items.Add($"{messageModel.Nickname}: {messageModel.Message}");
                                });
                            }
                            catch (Exception) { }
                        }
                    });
                }
                catch(Exception)
                {
                    this.serverSocket = null;
                    Dispatcher.Invoke(() =>
                    {
                        this.NicknameTextblock.Background = Brushes.Red;
                    });
                }
            });
        }

        private void SendButtonClick(object sender, RoutedEventArgs e)
        {
            string message = this.MessageTextbox.Text;

            if (this.serverSocket == null || string.IsNullOrEmpty(message))
            {
                this.MessageTextbox.Text = string.Empty;
                return;
            }

            SendMessage(this.serverSocket, new SendMessageModel(this.Nickname, message));
            this.MessageTextbox.Text = string.Empty;
        }

        private void SendMessage(Socket serverSocket, SendMessageModel model)
        {
            var json = JsonSerializer.Serialize(model);
            var messageModelInBytes = Encoding.UTF8.GetBytes(json);

            serverSocket.SendAsync(messageModelInBytes, SocketFlags.None);
        }
    }
}
