namespace AsyncAwaitApp;

using System.Data.SqlClient;
using Dapper;

public class Program {
    static Task<int> GetNumberAsync() {
        var task = new Task<int>(() => {
            Thread.Sleep(3000);
            return new Random().Next(100);
        });
        task.Start();

        return task;
    }

    static async Task DoSomethingAsync() {
        Console.WriteLine("DoSomething method start");

        List<int> numbers = new List<int>();

        // first
        var num = await GetNumberAsync();
        numbers.Add(num);
        Console.WriteLine($"(1) {num} added!");

        // second
        num = await GetNumberAsync();
        numbers.Add(num);
        Console.WriteLine($"(2) {num} added!");

        // third
        num = await GetNumberAsync();
        numbers.Add(num);
        Console.WriteLine($"(3) {num} added!");

        Console.WriteLine("DoSomething method end");
    }

    static async Task Main() {
        if(true) {
            string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";
            var connection = new SqlConnection(connectionString);
            var phonesCount = await connection.ExecuteScalarAsync<int>("select count(*) from Phones");
            Console.WriteLine(phonesCount);
        }

        if(false) {
            DoSomethingAsync();

            for (int i = 0; i < 100; i++) {
                Thread.Sleep(100);
                Console.WriteLine(i);
            }
        }

        if(false) {
            //var obj = Task.Run(() => { });
            //await Task.Run(() => { });

            var result1 = GetNumberAsync().Result;
            Console.WriteLine($"Result1 = {result1}");

            var result2 = await GetNumberAsync();
            Console.WriteLine($"Result2 = {result2}");
        }
    }
}