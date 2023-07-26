using System.Net.Sockets;
using System.Text;

var udpClient = new UdpClient(8000);

const string stopMessage = "image end";

int stopMessageSize = Encoding.UTF8.GetBytes(stopMessage).Length;

// receive
while (true) {
    var newFileName = $"{Guid.NewGuid()}.png";
    Console.WriteLine($"File {newFileName} started...");

    using FileStream fileStream = new FileStream(
        path: $"data\\{newFileName}",
        mode: FileMode.OpenOrCreate);

    int packetsCount = 0;
    for (packetsCount = 0; true; packetsCount++) {
        var result = await udpClient.ReceiveAsync();
        Console.WriteLine($"Packet (Size: {result.Buffer.Length} bytes) received for image: {newFileName}!");

        if (result.Buffer.Length == stopMessageSize && Encoding.UTF8.GetString(result.Buffer, 0, stopMessageSize) == stopMessage)
            break;

        await fileStream.WriteAsync(result.Buffer, 0, result.Buffer.Length);
    }

    await fileStream.FlushAsync();
    Console.WriteLine($"'{newFileName}' packets count: {packetsCount}");
}

Console.ReadKey();