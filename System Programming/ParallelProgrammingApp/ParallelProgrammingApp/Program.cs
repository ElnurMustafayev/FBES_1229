namespace ParallelProgrammingApp;

using System.Data.SqlClient;
using System.Text.Json;
using Dapper;


public class User {
    public string login { get; set; }
    public string password { get; set; }
}



public class Program {

    static bool CheckNumber(int num) {
        Thread.Sleep(300);
        Console.WriteLine(num);
        return num % 2 == 0;
    }

    static async Task Main() {
        if (false) {
            var json = await File.ReadAllTextAsync("Users.json");
            var users = JsonSerializer.Deserialize<IEnumerable<User>>(json);

            Parallel.ForEach(users, async user => {
                string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";
                var connection = new SqlConnection(connectionString);

                await connection.ExecuteAsync(
                    sql: "insert into Users ([Login], [Password]) values(@login, @password)",
                    param: new { user.login, user.password });
            });

            Console.ReadKey();
        }



        if (false) {
            int[] numbers = {
                0,1,2,3,4,5,6,7,8,9
            };

            // lambda
            // lambda expression

            //var result = numbers
            //    .AsQueryable()
            //    .Where(num => num % 2 == 0)
            //    .Select(num => num.ToString());

            //numbers
            //    .AsParallel()
            //    .Where(numStr => {
            //        Thread.Sleep(300);
            //        return true;
            //    })
            //    .Select(num => {
            //        Console.WriteLine(num);
            //        return num.ToString();
            //    })
            //    .ToList();




            //var result = from num in numbers.AsParallel()
            //             where CheckNumber(num)
            //             select num.ToString();

            //result.ToList();

            Console.ReadKey();
        }



        if (false) {
            Parallel.Invoke(
                new Action(() => { Console.WriteLine("1"); }),
                new Action(() => { Console.WriteLine("2"); }),
                new Action(() => { Console.WriteLine("3"); }),
                new Action(() => { Console.WriteLine("4"); }),
                new Action(() => { Console.WriteLine("5"); })
                );
        }


        if (false) {
            string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";

            var numbers = new string[] {
                "+994 111123456",
                "+994 222123456",
                "+994 333123456",
                "+994 444123456",
                "+994 555123456",
            };

            //var temp = new string[0].Where(async (obj) => {
            //    await JsonSerializer.DeserializeAsync(null, null);
            //    return true;
            //});

            Parallel.ForEach(numbers, async (number) => {
                var connection = new SqlConnection(connectionString);

                var affectedRows = await connection.ExecuteAsync(
                   sql: $@"insert into [Phones] values(@number)",
                   param: new { number });

                if (affectedRows > 0) {
                    Console.WriteLine($"{number} added");
                }
            });

            Console.ReadKey();
        }

        if (false) {
            int[] nums = {
                1,2,3,4,5,6,7,8,9
            };

            Parallel.ForEach(nums, num => {
                var filename = $"{num}.txt";
                Console.WriteLine($"Creating File {filename} started");
                Thread.Sleep(new Random().Next(10) * 1000);
                var stream = File.Create(filename);
                var writer = new StreamWriter(stream);
                var content = new string(num.ToString()[0], num);
                writer.WriteLine(content);
                writer.Flush();
                Console.WriteLine($"File {filename} created");
            });

            Console.ReadKey();
        }

        if (false) {
            Parallel.For(
                fromInclusive: 0,
                toExclusive: 30,
                body: (index, state) => {
                    Console.WriteLine($"{index} iteration");
                    //state.Break();
                });

            Console.ReadKey();
        }
    }
}