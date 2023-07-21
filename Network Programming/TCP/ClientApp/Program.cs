using System.Net;
using System.Net.Sockets;

var tcpClient = new TcpClient();

await tcpClient.ConnectAsync(
    address: IPAddress.Parse("127.0.0.1"),
    port: 8080);

NetworkStream networkStream = tcpClient.GetStream();

//var message = networkStream.ReadByte();
//Console.WriteLine(message);


// read
var reader = new StreamReader(networkStream);
ThreadPool.QueueUserWorkItem(async (state) =>
{
    while(true)
    {
        var message = await reader.ReadLineAsync();
        Console.WriteLine($"Message: {message}");
    }
});

// write
var writer = new StreamWriter(networkStream);
while (true)
{
    await writer.WriteLineAsync(Console.ReadLine());
    await writer.FlushAsync();
}