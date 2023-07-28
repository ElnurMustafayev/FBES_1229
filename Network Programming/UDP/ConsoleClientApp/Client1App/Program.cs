using System.Net;
using System.Net.Sockets;
using System.Text;

var udpClient = new UdpClient(8080);
//const int updPacketSizeLimit = 65000;

#region Allow UDP receive after send

    const uint IOC_IN = 0x80000000U;
    const uint IOC_VENDOR = 0x18000000U;

    // Controls whether UDP PORT_UNREACHABLE messages are reported. 
    const int SIO_UDP_CONNRESET = unchecked((int)(IOC_IN | IOC_VENDOR | 12));
    udpClient.Client.IOControl(SIO_UDP_CONNRESET, new byte[] { 0x00 }, null);

#endregion

ThreadPool.QueueUserWorkItem(async (state) => {
    while(true) {
        var updReceiveResult = await udpClient.ReceiveAsync();

        var message = Encoding.UTF8.GetString(updReceiveResult.Buffer);

        Console.WriteLine($"{updReceiveResult.RemoteEndPoint}: {message}");
    }
});

const int packetSize = 100;

//send
while (true) {
    Console.Write("Put Image path: ");
    var imagePath = Console.ReadLine();

    if (File.Exists(imagePath)) {
        var imageInBytes = File.ReadAllBytes(imagePath);

        for (int packetNumber = 0; true; packetNumber++) {
            byte[] packetToSend = imageInBytes
                .Skip(packetNumber * packetSize)
                .Take(packetSize)
                .ToArray();

            if(packetToSend.Length == 0) {
                byte[] endMessage = Encoding.UTF8.GetBytes("image end");

                await udpClient.SendAsync(
                    datagram: endMessage,
                    bytes: endMessage.Length,
                    endPoint: new IPEndPoint(
                        address: IPAddress.Parse("127.0.0.1"),
                        port: 8000)
                    );

                break;
            }

            if (packetNumber != 0 && packetNumber % 100 == 0)
                continue;

            int size = await udpClient.SendAsync(
                datagram: packetToSend,
                bytes: packetToSend.Length,
                endPoint: new IPEndPoint(
                    address: IPAddress.Parse("127.0.0.1"),
                    port: 8000)
                );
                
            Console.WriteLine($"{packetNumber} packet for '{new FileInfo(imagePath).Name}' image");
        }
    }
}