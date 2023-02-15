using System.Text;

namespace FilesApp;

class MyStream : IDisposable {
    public void Dispose() {
        Console.WriteLine("MyStream Disposed");
    }
}

class Program {
    static void Main() {
        // FILE
        if(false) {
            //string text = File.ReadAllText(path: "new.txt");
            //Console.WriteLine(text);

            //var lines = File.ReadAllLines(path: "new.txt");
            //foreach (var line in lines)
            //    Console.WriteLine($" - {line}");

            //File.Copy("new.txt", $"{Guid.NewGuid().ToString("N")[..6]}_copy.txt");

            //string filename = "b86ca7_copy.txt";
            //if (File.Exists(filename))
            //    File.Delete(filename);

            //var creationDate = File.GetCreationTime("new.txt");
            //Console.WriteLine(creationDate);

            //var info = new FileInfo("new.txt");
            //Console.WriteLine(info);
        }



        // USING
        if(false) {
            byte[] buffer = new byte[5];
            int size = 0;

            using (MyStream stream = new MyStream()) {
                Console.WriteLine("One");
                Console.WriteLine("Two");
                int num = 2;
                Console.WriteLine(num / 0);
                Console.WriteLine("Three");
                Console.WriteLine("Four");
                Console.WriteLine("Five");
            }

            using (Stream stream = new FileStream("new.txt", FileMode.Open, FileAccess.Read)) {
                buffer = new byte[5];
                size = stream.Read(buffer, 0, buffer.Length);
            }

            var message = Encoding.UTF8.GetString(buffer, 0, size);
            Console.WriteLine(message);
        }

        // FINALLY
        try {
            if (false) {
                Stream stream = new FileStream(
                        path: "new.txt",
                        mode: FileMode.Open,
                        access: FileAccess.Read);
                byte[] buffer = new byte[5];
                int size = 0;

                try {
                    size = stream.Read(buffer, 0, buffer.Length);
                }
                catch (Exception ex) {
                    Console.WriteLine($"Error for buffer with length {buffer.Length}: '{ex.Message}'");
                }
                finally {
                    Console.WriteLine("finally");
                    stream.Dispose();
                }

                var message = Encoding.UTF8.GetString(buffer, 0, size);
                Console.WriteLine(message);
            }
        }
        catch {
            Console.WriteLine("End catch");
        }
        


        // StreamReader
        if (false) {
            StreamReader reader = new StreamReader("new.txt");
            //Console.WriteLine();

            //var line = reader.ReadLine();
            var text = reader.ReadToEnd();

            //Console.WriteLine(line);
            Console.WriteLine(text);
        }

        // StreamWriter
        if (false) {
            Stream stream = new FileStream(
                path: "new.txt",
                mode: FileMode.Append,
                access: FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.AutoFlush = true;

            writer.Write("Test");
            writer.WriteLine(123.56);
            //writer.Flush();
        }



        // Stream Write
        if (false) {
            Stream stream = new FileStream(
                path: "test.txt",               // alternative path:  .\bin\Debug\net6.0
                mode: FileMode.Append,
                access: FileAccess.Write);

            //byte symbolNum = 97;
            //stream.WriteByte(symbolNum++);  // a
            //stream.WriteByte(symbolNum++);  // b
            //stream.Flush();                 // ab
            //stream.WriteByte(symbolNum++);  // c
            //stream.WriteByte(symbolNum++);  // d
            //stream.Flush();                 // cd


            //var buffer = new byte[] {
            //    123,111,97,100
            //};
            //stream.Write(buffer, 0, buffer.Length);
            //stream.Flush();


            string message = "Hello World!";
            var buffer = Encoding.UTF8.GetBytes(message);

            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            //foreach (char symbol in message) {
            //    stream.WriteByte(Convert.ToByte(symbol));
            //}
            //stream.Flush();
        }

        // Stream Read
        if (false) {
            Stream stream = new FileStream(
                path: "test.txt",
                mode: FileMode.Open,
                access: FileAccess.Read);

            byte[] buffer = new byte[10];

            while(true) {
                var size = stream.Read(buffer, 0, buffer.Length);

                if(size == 0)
                    break;

                var message = Encoding.UTF8.GetString(buffer, 0, size);

                Console.Write(message);
                Thread.Sleep(100);
            }
        }
    }
}