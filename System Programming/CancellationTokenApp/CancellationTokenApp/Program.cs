namespace CancellationTokenApp;

public class Program {
    static void WriteAlphabetInFile(string filePath, CancellationToken token) {
        var thread = new Thread(() => {
            token.Register(() => {
                Console.WriteLine("\nToken Canceled");
            });

            File.WriteAllText(filePath, string.Empty);

            Console.Write("Writing started: ");

            for (char i = 'a'; i <= 'z'; i++) {
                Thread.Sleep(300);
                if (token.IsCancellationRequested)
                    break;

                Console.Write('|');
                File.AppendAllText(filePath, i.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Writing end.");
        });

        thread.Start();
    }

    static void Main() {
        if(true) {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            WriteAlphabetInFile("alphabet.txt", tokenSource.Token);

            Console.ReadKey();
            tokenSource.Cancel();
        }


        if (false) {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            ThreadPool.QueueUserWorkItem((obj) => {
                Console.WriteLine("Thread Start");
                //int num = 10;
                //token.Register(() => {
                //    num = -1;
                //});

                for (int i = 0; i < 10 && !token.IsCancellationRequested; i++) {
                    Console.WriteLine(i);
                    Thread.Sleep(500);

                    //if (token.IsCancellationRequested) {
                    //    break;
                    //}
                }
                Console.WriteLine("Thread End");
            });

            Console.ReadKey();
            tokenSource.Cancel();
            Console.ReadKey();
        }


        if (false) {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            token.Register(() => {
                Console.WriteLine("CancellationRequested!!!");
            });

            Console.WriteLine(token.IsCancellationRequested);
            tokenSource.Cancel();
            Console.WriteLine(token.IsCancellationRequested);
        }
    }
}