using System.Net.Sockets;
using System.Net;
using System.Text.Json;
using SharedLib.Requests.Base;
using SharedLib.Requests;
using ServerApp.Repositories;




TcpListener tcpListener = new TcpListener(
    localaddr: IPAddress.Parse("127.0.0.1"),
    port: 8080);

tcpListener.Start(backlog: 5);
Console.WriteLine("Server started!");

var clients = new List<TcpClient>();

UserRepository userRepository = new UserRepository();

while (true) {
    TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
    clients.Add(tcpClient);
    Console.WriteLine("Client Connected!");

    Task.Run(async () => {
        NetworkStream clientNetworkStream = tcpClient.GetStream();

        // read
        var reader = new StreamReader(clientNetworkStream);
        Task.Run(async () => {
            while (true) {
                var messageJson = await reader.ReadLineAsync();

                Console.WriteLine(messageJson);
                var requestBase = JsonSerializer.Deserialize<Request>(messageJson);

                if (requestBase == null)
                    continue;

                switch (requestBase.RequestType) {
                    case nameof(LoginRequest): {
                            var request = JsonSerializer.Deserialize<Request<LoginRequest>>(messageJson);

                            var login = request?.Data?.Login;
                            var password = request?.Data?.Password;

                            var success = await userRepository.LoginAsync(login, password);
                            Console.WriteLine($"Login: {login}:{password} => {success}");
                        }
                        break;
                    case nameof(RegistrationRequest): {
                            var request = JsonSerializer.Deserialize<Request<RegistrationRequest>>(messageJson);

                            var mail = request?.Data?.Mail;
                            var gender = request?.Data?.Gender;
                            var password = request?.Data?.Password;

                            await userRepository.RegisterAsync(mail, gender, password);

                            Console.WriteLine($"Register: {mail}:{gender}:{password} => Success");
                        }
                        break;
                    default:
                        continue;
                }
            }
        });
    });
}