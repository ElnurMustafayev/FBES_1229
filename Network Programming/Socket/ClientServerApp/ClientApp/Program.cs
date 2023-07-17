using System.Net.Sockets;
using System.Text;

namespace ClientApp;

public class Program {
    public static async Task Main() {
        Socket socket = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp);

        const string serverAddress = "127.0.0.1";
        const short port = 8080;
        await socket.ConnectAsync(serverAddress, port);
        Console.WriteLine($"Client connected to {serverAddress}:{port}!");

        bool serverIsWorking = true;

        ThreadPool.QueueUserWorkItem(async (state) => {
            byte[] buffer = new byte[1024];
            while(serverIsWorking)
            {
                try
                {
                    int messageSize = await socket.ReceiveAsync(buffer, SocketFlags.None);
                    string messageFromClient = Encoding.UTF8.GetString(buffer, 0, messageSize);
                    Console.WriteLine($"Answer from server: '{messageFromClient}'");
                }
                catch(SocketException)
                {
                    Console.WriteLine("Server turned off");
                    serverIsWorking = false;
                }
            }
        });

        Console.WriteLine("Send Message to server: ");
        while(serverIsWorking)
        {
            string? message = Console.ReadLine();
            if (serverIsWorking && string.IsNullOrEmpty(message) == false)
            {
                byte[] messageInBytes = Encoding.UTF8.GetBytes(message);
                await socket.SendAsync(messageInBytes, SocketFlags.None);
            }
        }
    }
}