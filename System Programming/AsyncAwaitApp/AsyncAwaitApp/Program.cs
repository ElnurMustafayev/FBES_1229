namespace AsyncAwaitApp;

public class Program {
    static Task<int> GetNumber() {
        var task = new Task<int>(() => {
            Thread.Sleep(3000);
            return new Random().Next(100);
        });
        task.Start();

        return task;
    }

    static async Task DoSomething() {
        Console.WriteLine("DoSomething method start");

        List<int> numbers = new List<int>();

        // first
        var num = await GetNumber();
        numbers.Add(num);
        Console.WriteLine($"(1) {num} added!");

        // second
        num = await GetNumber();
        numbers.Add(num);
        Console.WriteLine($"(2) {num} added!");

        // third
        num = await GetNumber();
        numbers.Add(num);
        Console.WriteLine($"(3) {num} added!");

        Console.WriteLine("DoSomething method end");
    }

    static async Task Main() {
        if(true) {
            DoSomething();

            for (int i = 0; i < 100; i++) {
                Thread.Sleep(100);
                Console.WriteLine(i);
            }
        }

        if(false) {
            //var obj = Task.Run(() => { });
            //await Task.Run(() => { });

            var result1 = GetNumber().Result;
            Console.WriteLine($"Result1 = {result1}");

            var result2 = await GetNumber();
            Console.WriteLine($"Result2 = {result2}");
        }
    }
}