namespace ThreadsApp;

using System.Data.SqlClient;
using Dapper;

public class Program {
    public static void Main() {
        if(true) {
            var thread = new Thread(() => { });
            thread.Start();
            thread.Interrupt();
        }


        if(false) {
            new Thread(() => {
                Console.WriteLine($"'{Thread.CurrentThread.Name}' thread started!");
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }) {
                IsBackground = true,
                Priority = ThreadPriority.Highest,
                Name = "My Thread",
            }.Start();


            Console.WriteLine("One");
            Thread.Sleep(500);
            Console.WriteLine("Two");
            Thread.Sleep(500);
            Console.WriteLine("Three");
            Thread.Sleep(500);
        }


        if(false) {
            string connectionString = $"Server=localhost;Database=MyAppDb;User Id=admin;Password=admin;";

            var thread = new Thread(() => {
                var connection = new SqlConnection(connectionString);

                var result = connection.ExecuteScalar<string>("select max(u.[Name]) from [Users] u");

                Console.WriteLine($"Max name: {result}");
            });

            thread.Start();

            for (int i = 0; i < 100; i++) {
                Thread.Sleep(10);
                Console.WriteLine(i);
            }

        }


        if (false) {
            ParameterizedThreadStart start = (message) => {
                var length = message.ToString().Length;
                for (int i = 0; i < length; i++) {
                    Thread.Sleep(length * 100);
                    Console.WriteLine(message);
                }
            };

            new Thread(start).Start("qwerty");
            new Thread(start).Start("my name is Bob");
            new Thread(start).Start("lol");
        }



        if (false) {
            ParameterizedThreadStart start = (endNum) => {
                for (int i = 0; i < (int)endNum; i++) {
                    Console.Write(i);
                }
            };

            new Thread(start).Start(5);
            new Thread(start).Start(10);
            new Thread(start).Start(3);
        }



        if (false) {
            var thread = new Thread(start: (obj) => {
                Console.WriteLine(obj);
            });

            thread.Start(150);
        }




        if(false) {
            // thread => 1 - 100 (thread end)

            // main => 1 - 200 (main end)

            var thread = new Thread(start: () => {
                for (int i = 0; i < 100; i++) {

                }
                Console.WriteLine("thread end");
            });
            thread.Start();



            for (int i = 0; i < 200; i++) {

            }
            Console.WriteLine("main end");
        }


        if (false) {
            ThreadStart threadStart = () => {
                // Thread.Sleep(5000); // duetime (kostil)
                Console.WriteLine("Thread 1");
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
                Thread.Sleep(1000);
            };

            Thread thread = new Thread(threadStart);
            thread.Start();

            Console.WriteLine("Main 1");
            Thread.Sleep(1000);
            Console.WriteLine("Main 2");
            Thread.Sleep(1000);
            Console.WriteLine("Main 3");
            Thread.Sleep(1000);
        }



        if (false) {
            //Thread mainThread = Thread.CurrentThread;
            //Console.WriteLine(mainThread.Name);
        }
    }
}