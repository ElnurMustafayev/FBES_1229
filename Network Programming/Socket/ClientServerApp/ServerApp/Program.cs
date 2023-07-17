namespace ServerApp;

using System.Net;
using System.Net.Sockets;
using System.Text;

public class Program {
    public static async Task Main() {
        Socket serverSocket = new Socket(
            AddressFamily.InterNetwork, 
            SocketType.Stream, 
            ProtocolType.Tcp);

        //var ipAddress = new IPAddress(new byte[] { 127, 0, 0, 1 });
        const string serverAddress = "127.0.0.1";
        const short port = 8080;
        var ipAddress = IPAddress.Parse(serverAddress);
        var endpoint = new IPEndPoint(ipAddress, port);

        serverSocket.Bind(endpoint);
        serverSocket.Listen(5);
        Console.WriteLine($"Server started on {serverAddress}:{port}!");

        while(true)
        {
            Socket clientSocket = await serverSocket.AcceptAsync();
            Console.WriteLine("Client connected!");

            // For client
            ThreadPool.QueueUserWorkItem(async (state) =>
            {
                try
                {
                    Console.WriteLine("Client Start");

                    while(true)
                    {
                        byte[] buffer = new byte[1024];
                        int messageSize = await clientSocket.ReceiveAsync(buffer, SocketFlags.None);
                        Console.WriteLine("Message received!");

                        string messageFromClient = Encoding.UTF8.GetString(buffer, 0, messageSize);
                        Console.WriteLine($"Message: '{messageFromClient}'");

                        if(messageFromClient.ToLower().Contains("bob")) {
                            var messageToClient = Encoding.UTF8.GetBytes("Hello, Bob!");
                            await clientSocket.SendAsync(messageToClient, SocketFlags.None);
                        }
                    }
                }
                catch(SocketException)
                {
                    Console.WriteLine("Client disconnected!");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"System error: '{ex.Message}'");
                }
                finally
                {
                    Console.WriteLine("Client End");
                }
            });
        }
    }
}