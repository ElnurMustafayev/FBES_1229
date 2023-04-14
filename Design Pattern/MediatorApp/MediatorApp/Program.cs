using MediatorApp.ViewModels;

namespace MediatorApp;

public class Program {
    static void Main() {
        var messenger = new Messenger();

        var vm1 = new AuthViewModel(messenger);
        var vm2 = new ViewModel1(messenger);
        var vm3 = new ViewModel2(messenger);

        vm1.Login("admin", "admin");

        //const string key = "secret";

        //messenger.Subscribe(key, obj => {
        //    Console.WriteLine($"Action for '{key}' key; Message = '{obj}'");
        //});

        //messenger.Send(key, "Hello World");
    }
}