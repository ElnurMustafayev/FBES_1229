using System.Text;

namespace FilesApp;

class Program {
    static void Main() {
        // WRITE
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

        // READ
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