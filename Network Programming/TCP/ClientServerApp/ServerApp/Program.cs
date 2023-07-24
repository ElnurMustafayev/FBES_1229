using System.Net;
using System.Net.Sockets;

TcpListener tcpListener = new TcpListener(
    localaddr: IPAddress.Parse("127.0.0.1"),
    port: 8080);

tcpListener.Start(backlog: 5);
Console.WriteLine("Server started!");

var clients = new List<TcpClient>();

while(true)
{
    TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
    clients.Add(tcpClient);
    Console.WriteLine("Client Connected!");

    //NetworkStream clientNetworkStream = tcpClient.GetStream();
    //clientNetworkStream.WriteByte(95);
    //await clientNetworkStream.FlushAsync();
    
    Task.Run(async () =>
    {
        NetworkStream clientNetworkStream = tcpClient.GetStream();

        // read
        var reader = new StreamReader(clientNetworkStream);
        Task.Run(async () =>
        {
            while(true)
            {
                var message = await reader.ReadLineAsync();
                Console.WriteLine(message);
            }
        });

        // write
        var writer = new StreamWriter(clientNetworkStream);
        while (true)
        {
            var message = $"Hello Client {tcpClient.GetHashCode()}!";
            Thread.Sleep(1000);
            await writer.WriteLineAsync(message);
            await writer.FlushAsync();

            //Thread.Sleep(3000);
            //var requestJson = await File.ReadAllTextAsync("request.json");
            //await writer.WriteLineAsync(requestJson);
            //await writer.FlushAsync();
        }
    });
}
