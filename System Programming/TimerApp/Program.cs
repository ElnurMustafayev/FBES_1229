namespace TimerApp;

public class User {
    public string Name { get; set; }
}

public class Program {
    public static void Main() {
        // Timer timer = new Timer(
        //     callback: (state) => System.Console.WriteLine(state),
        //     state: "Test",
        //     dueTime: 0,
        //     period: 1000
        // );

        // Thread.Sleep(2000);
        // System.Console.WriteLine("One");
        // Thread.Sleep(2000);
        // System.Console.WriteLine("Two");
        // Thread.Sleep(2000);
        // System.Console.WriteLine("Three");
        // Thread.Sleep(2000);








        //User user = new User() { Name = "Bob" };

        //Timer timer = new Timer((obj) => {
        //    Console.WriteLine((obj as User).Name);
        //}, user, 0, 1000);

        //Console.ReadKey();
        //user.Name = "Alex";
        //Console.ReadKey();



        Timer timer = new Timer((obj) => {
            Console.WriteLine("tick");
        }, null, 0, 1000);

        for (int i = 0; true; i++) {
            Thread.Sleep(200);
            Console.WriteLine(i);
        }
    }
}