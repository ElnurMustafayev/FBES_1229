using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using Shared;

Dictionary<string, Socket> Clients = new Dictionary<string, Socket>();

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

while (true)
{
    Socket clientSocket = await serverSocket.AcceptAsync();
    Console.WriteLine("Client connected!");

    // For client
    ThreadPool.QueueUserWorkItem(async (state) =>
    {
        string? currentClientName = null;
        try
        {

            while (true)
            {
                byte[] buffer = new byte[1024];
                int messageSize = await clientSocket.ReceiveAsync(buffer, SocketFlags.None);
                string messageModelJson = Encoding.UTF8.GetString(buffer, 0, messageSize);
                var messageModel = JsonSerializer.Deserialize<SendMessageModel>(messageModelJson);

                if (string.IsNullOrEmpty(messageModel?.Nickname))
                    continue;

                // add client if new
                if(currentClientName == null && Clients.ContainsKey(messageModel.Nickname) == false)
                {
                    currentClientName = messageModel.Nickname;
                    Clients.Add(currentClientName, clientSocket);
                }

                if(messageModel.IsSpecial == false)
                {
                    foreach (var client in Clients)
                    {
                        var responseToClients = Encoding.UTF8.GetBytes(messageModelJson);
                        await client.Value.SendAsync(responseToClients, SocketFlags.None);
                    }
                }

                Console.WriteLine($"{messageModel?.Nickname ?? "Unknown"}: {messageModel?.Message}");
            }
        }
        catch (SocketException)
        {
            Console.WriteLine("Client disconnected!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"System error: '{ex.Message}'");
        }
        finally
        {
            if(currentClientName != null)
                Clients.Remove(currentClientName);
        }
    });
}