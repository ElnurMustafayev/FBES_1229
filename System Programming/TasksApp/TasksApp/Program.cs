namespace TasksApp;

public class Program {
    static Task AsyncMethod() {
        var task = new Task(() => {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);
                Thread.Sleep(250);
            }
        });

        task.Start();

        return task;
    }

    static void Main() {
        if(false) {
            Task<string> task = Task.Run<string>(() => {
                Thread.Sleep(3000);
                return Guid.NewGuid().ToString();
            });

            Console.WriteLine(task.Result);
        }


        if(false) {
            Task<int> task = new Task<int>(() => {
                Thread.Sleep(10000);
                return 10;
            });
            task.Start();

            var num = task.Result;

            Console.WriteLine(num);
        }


        if(false) {
            var task = Task.Run(() => {
                Console.WriteLine("Hello World!");
            });

            Task.WaitAll(task);
        }

        if(false) {
            var task1 = new Task(() => {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"Thread {threadId} start...");
                Thread.Sleep(5000);
                Console.WriteLine($"Thread {threadId} end...");
            });
            task1.Start();

            var task2 = new Task(() => {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"Thread {threadId} start...");
                Thread.Sleep(1500);
                Console.WriteLine($"Thread {threadId} end...");
            });
            task2.Start();

            //Task.WaitAny(task1, task2);
            Task.WaitAll(task1, task2);
            Console.WriteLine("All tasks done!");
        }





        if(false) {
            var task = AsyncMethod();
            task.Wait();

            //Console.ReadKey();
        }


        if(false) {
            var task = new Task(() => {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine(i);
                    Thread.Sleep(250);
                }
            });

            Console.WriteLine("Start");
            task.Start();
            task.Wait();
            Console.WriteLine("End");
        }


        if(false) {
            var task = new Task((num) => {
                Console.WriteLine($"Hello World {num}");
            }, 123);

            task.Start();

            Console.ReadKey();
        }

        if (false) {
            //new Thread((obj) => { }).Start();
            //ThreadPool.QueueUserWorkItem((obj) => { });


            //int num = 0;

            //var thread = new Thread(() => 123);
            //num = thread.Start();

            //Console.WriteLine(num);
        }
    }
}