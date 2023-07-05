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