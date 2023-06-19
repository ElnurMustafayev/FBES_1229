Timer timer = new Timer(
    callback: (state) => System.Console.WriteLine(state),
    state: "Test",
    dueTime: 0,
    period: 1000
);

Thread.Sleep(2000);
System.Console.WriteLine("One");
Thread.Sleep(2000);
System.Console.WriteLine("Two");
Thread.Sleep(2000);
System.Console.WriteLine("Three");
Thread.Sleep(2000);