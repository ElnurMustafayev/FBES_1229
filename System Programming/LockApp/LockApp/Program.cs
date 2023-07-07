public class Program {
    private static void Main() {
        if(false) {
            Mutex mutex = new Mutex(true, "MyMutex", out bool createdNew);

            if (createdNew == false)
                throw new Exception("Application already opened!");

            Console.ReadKey();
        }


        if(false) {
            Mutex mutex = new Mutex(false, "MyMutex");
            bool result = mutex.WaitOne();
            Console.WriteLine(result);
            Console.ReadKey();
            mutex.ReleaseMutex();
            Console.ReadKey();
        }


        if(true) {
            object locker = new object();
            int num = 0;

            //Mutex mutex = new Mutex();
            //Semaphore semaphore = new Semaphore(1, 1);

            var task1 = Task.Run(() => {
                Console.WriteLine("Task 1 start.");
                for (int i = 0; i < 1_500_000; i++) {
                    //Interlocked.Increment(ref num);
                    //mutex.WaitOne();
                    //semaphore.WaitOne();
                    //Monitor.Enter(locker);
                    lock (locker) {
                        num++;
                    }
                    //Monitor.Exit(locker);
                    //semaphore.Release();
                    //mutex.ReleaseMutex();
                }
                Console.WriteLine("Task 1 end.");
            });

            var task2 = Task.Run(() => {
                Console.WriteLine("Task 2 start.");
                for (int i = 0; i < 2_000_000; i++) {
                    //Interlocked.Increment(ref num);
                    //mutex.WaitOne();
                    //semaphore.WaitOne();
                    //Monitor.Enter(locker);
                    lock (locker) {
                        num++;
                    }
                    //Monitor.Exit(locker);
                    //semaphore.Release();
                    //mutex.ReleaseMutex();
                }
                Console.WriteLine("Task 2 end.");
            });

            Task.WaitAll(task1, task2);
            Console.WriteLine(num);
        }
    }
}