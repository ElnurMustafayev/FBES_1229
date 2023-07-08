using System.Runtime.CompilerServices;

namespace StateMachineApp;

class Program {
    // Gets random number from 0 to {max}
    static Task<int> GetRandomAfter(int max = 100) {
        return Task.Run<int>(() => {
            Thread.Sleep(1000);
            return new Random().Next(0, max);
        });
    }

    // "async/await" in normal
    static async void AsyncAwait() {
        Console.WriteLine("Thread start");

        var first = await GetRandomAfter(100);
        Console.WriteLine($"The first: {first}");

        var second = await GetRandomAfter(100);
        Console.WriteLine($"The second: {second}");

        var sum = first + second;
        System.Console.WriteLine($"{first} + {second} = {sum}");

        Console.WriteLine("Thread end");
    }

    static void Main(string[] args) {
        // before compilation
        //AsyncAwait();

        // after compilation
        AsyncAwaitCompiled();

        // something goes after the async method
        for (int i = 0; i < 100; i++) {
            Thread.Sleep(100);
            System.Console.WriteLine(i);
        }

        // don't exit
        Console.ReadKey();
    }

    // "async/await" after compilation
    static void AsyncAwaitCompiled() {
        // async/await method converts in StartFuncStateMachine object
        var stateMachine = new StartFuncStateMachine {
            // status "start" by default
            State = -1,
            Builder = AsyncVoidMethodBuilder.Create()
        };

        // start method
        stateMachine.Builder.Start(ref stateMachine);
    }

    // StateMecine which represents Async/Await functionality after compiling
    struct StartFuncStateMachine : IAsyncStateMachine {
        public AsyncVoidMethodBuilder Builder;

        // StateMachine status
        // -1           Start
        // -2           End
        //  0, 1, 2     await calls' steps
        public int State;

        // awaiters of all await methods
        private TaskAwaiter<int> awaiter1;
        private TaskAwaiter<int> awaiter2;

        // method's local variables
        private int first;
        private int second;
        private int sum;

        public void MoveNext() {
            try {
                switch (this.State) {
                    // Before the first await
                    case -1:
                        Console.WriteLine("Thread start");
                        // get awaiter from first await method
                        this.awaiter1 = GetRandomAfter(100).GetAwaiter();

                        // if awaiter executing end immediately
                        if (this.awaiter1.IsCompleted) {
                            // change state to next and go
                            this.State = 0;
                            goto case 0;
                        }
                        else {
                            this.State = 0;
                            // run waiter for awaiter1 and will call this.MoveNext() inside
                            Builder.AwaitUnsafeOnCompleted(ref awaiter1, ref this);
                            return;
                        }
                    // Before the second await
                    case 0:
                        this.first = awaiter1.GetResult();
                        Console.WriteLine($"The first: {this.first}");
                        this.awaiter2 = GetRandomAfter(100).GetAwaiter();

                        if (this.awaiter2.IsCompleted) {
                            this.State = 1;
                            goto case 1;
                        }
                        else {
                            this.State = 1;
                            Builder.AwaitUnsafeOnCompleted(ref this.awaiter2, ref this);
                            return;
                        }
                    // After the second await
                    case 1:
                        this.second = this.awaiter2.GetResult();
                        Console.WriteLine($"The second: {this.second}");
                        this.sum = this.first + this.second;
                        System.Console.WriteLine($"{this.first} + {this.second} = {this.sum}");
                        Console.WriteLine("Thread end");
                        this.State = -2;
                        return;
                }
            }
            catch (Exception exception) {
                this.State = -2;
                Builder.SetException(exception);
            }
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine) {
            Builder.SetStateMachine(stateMachine);
        }
    }
}