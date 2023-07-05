namespace ThreadPoolApp;

public class Person {
    public string? Name { get; set; }

    public Person(string? name) {
        this.Name = name;
    }
}

public class Program {
    static void Main() {
        if(false) {
            var person = new Person("Bob");

            ThreadPool.QueueUserWorkItem(
                callBack: (state) => {
                    Console.WriteLine(state.Name);
                },
                state: person,
                preferLocal: true);
        }

        if (false) {
            var person = new Person("Bob");

            ThreadPool.QueueUserWorkItem(
                callBack: (state) => {
                    Console.WriteLine((state as Person)?.Name);
                    //Console.WriteLine(state);
                },
                state: person);

            Console.ReadKey();
        }

        if (false) {
            ThreadPool.QueueUserWorkItem((obj) => {
                Thread.Sleep(3000);
                Console.WriteLine(obj);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }, "Hello World!");

            ThreadPool.QueueUserWorkItem((obj) => {
                Thread.Sleep(3000);
                Console.WriteLine(obj);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }, "Hello World!");

            Console.ReadKey();
        }
    }
}