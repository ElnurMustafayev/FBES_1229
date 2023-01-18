using System.Text;

namespace StringBuilderApp {
    class Program {

        static string InputNames(byte namesCount) {
            StringBuilder namesSb = new StringBuilder(namesCount * 10);

            for (byte i = 0; i < namesCount; i++) {
                namesSb.AppendLine(Console.ReadLine());
            }

            return namesSb.ToString();
        }

        static void ShowNames(string[] names) {
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine($"Name {i + 1}: {names[i]}");
        }

        static void Main(string[] args) {
            string namesStr = InputNames(5);
            string[] names = namesStr.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Console.Clear();
            ShowNames(names);




            //StringBuilder sb = new StringBuilder(5);

            //sb.Append("One");
            //sb.Append("Two");
            //sb.Append("Three");

            //Console.WriteLine(sb.ToString());





            //int num = 0;

            //num += 10;
            //num = 123;


            //string str = "text";

            ////str += "one";
            //str = new string("textone");

            //str += "two";
            //str += "three";

            //Console.WriteLine(str);



            //string str = "one";
            //str = new string("two");
            //str = "three";

            //Console.WriteLine(str);
        }
    }
}