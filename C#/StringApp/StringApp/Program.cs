using System;
using System.Text;

namespace StringApp {
    class Program {
        static void Main() {
            /*
            string name = "Elnur";
            string surname = "Mustafayev";
            string message1 = string.Format("Hello, {0} {1}", name, surname);
            string message2 = $"Hello, {name} {surname}";
            string message3 = @"q\we""rt/y";
            string message4 = @"one 
   two 
 three";

            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
            Console.WriteLine(message4);
            */

            //int num1 = int.Parse("123");
            //int num2 = Convert.ToInt32("123");
            //Console.WriteLine($"{num1} {num2}");

            //int num = 123;
            //Console.WriteLine(num.CompareTo(122));
            //Console.WriteLine(num.CompareTo(123));
            //Console.WriteLine(num.CompareTo(124));



            //Console.OutputEncoding = Encoding.Unicode;
            //for (int i = 0; i < 1000; i++) {
            //    char symbol = (char)i;
            //    Console.Write(symbol);
            //}


            //char ucode = '\u263C';
            //Console.WriteLine($"{(int)ucode} {sizeof(char)} {ucode}");


            //Console.Write("Money: ");
            //string moneyStr = Console.ReadLine();
            //double money = Convert.ToDouble(moneyStr);

            //string personStatus = money > 10_000 ? "Rich" : "Poor";
            //Console.WriteLine($"You are '{personStatus}'");


            //string str = "!!!";

            //string text = string.Concat("test", "\t", "salam", str);
            //Console.WriteLine(text);

            //string input = Console.ReadLine();
            //Console.WriteLine("Null or Empty: " + string.IsNullOrEmpty(input));
            //Console.WriteLine("Null or WhiteSpace: " + string.IsNullOrWhiteSpace(input));

            //if (input != null && input.Length > 0) {
            //if (!string.IsNullOrWhiteSpace(input)) {
            //    int num = Convert.ToInt32(input);
            //    Console.WriteLine(++num);
            //}

            //Console.WriteLine($"User input: \"{input}\"");








            //Console.WriteLine(string.IsNullOrEmpty("qwerty"));          // False
            //Console.WriteLine(string.IsNullOrEmpty("     "));           // False
            //Console.WriteLine(string.IsNullOrWhiteSpace("     "));      // True  
            //Console.WriteLine(string.IsNullOrEmpty(""));                // True
            //Console.WriteLine(string.IsNullOrEmpty(null));              // True


            //Console.OutputEncoding = Encoding.Unicode;

            //string symbol = "Hello \u1234 World!";

            //Console.WriteLine(symbol);


            //string str = "Hello World!";

            /*
            int; Int32;
            long; Int64;
            short; Int16;
            byte; Byte;
            string; String;
            decimal; Decimal;
            */

            //string str = "Hello World!";

            //Console.WriteLine(str.EndsWith('d'));
            //Console.WriteLine(str.EndsWith('!'));
            //Console.WriteLine(str.EndsWith("World!"));
            //Console.WriteLine(str.EndsWith("Hello"));



            //string str = "Hello World!";

            //char symbolToFind = '!';

            //int index = str.IndexOf(symbolToFind);

            //if(index == -1) {
            //    Console.WriteLine($"Symbol '{symbolToFind}' not found in '{str}'!");
            //}
            //else {
            //    Console.WriteLine($"IndexOf: Symbol '{symbolToFind}' in '{str}' is on index: {index}");
            //}



            // text1 (search in)            // Lorem ipsum dolor sit amet, consectetur adipiscing elit.
            // text2 (search by)            // amet
            // success:     Index: {index}
            // error:       {text2} Not found in {text1}!

            //while(true) {
            //    Console.Clear();
            //    Console.Write("Text to search in: ");
            //    string searchIn = Console.ReadLine();
            //    Console.Write("Text to search by: ");
            //    string searchBy = Console.ReadLine();

            //    // error
            //    if(string.IsNullOrWhiteSpace(searchIn) || string.IsNullOrWhiteSpace(searchBy)) {
            //        Console.WriteLine("Text can not be empty!");
            //        Console.ReadKey();
            //        continue;
            //    }

            //    int index = searchIn.IndexOf(searchBy);

            //    // error
            //    if(index == -1) {
            //        Console.WriteLine($"'{searchBy}' Not found in '{searchIn}'!");
            //        Console.ReadKey();
            //        continue;
            //    }

            //    // success
            //    else {
            //        Console.WriteLine($"Index: {index}");
            //        break;
            //    }
            //}


            //string str = "Hello World!";

            //Console.WriteLine(str.IndexOf('o'));        // 4
            //Console.WriteLine(str.LastIndexOf('o'));    // 7


            //int pad = 15;

            //Console.WriteLine("123".PadLeft(pad));
            //Console.WriteLine("12345".PadLeft(pad));
            //Console.WriteLine("12".PadLeft(pad));
            //Console.WriteLine("123456789".PadLeft(pad));
            //Console.WriteLine("1".PadLeft(pad));
            //Console.WriteLine("1234567".PadLeft(pad));
            //string str = "Hello World";
            //string result = str.PadLeft(20);

            //Console.WriteLine(result + "!");



            //string str = "Hello World!";
            //Console.WriteLine($"Before: {str}");
            //str = str.Remove(3);
            //Console.WriteLine($"After: {str}");




            //string str = "Hello World!";

            //string result1 = str.Replace('l', '$');
            //string result2 = str.Replace("or", "ororororor");

            //Console.WriteLine(str);
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);

            //char symbol = 'W';
            //string str = "Hello World!";

            //if(str.Contains(symbol)) {
            //    string result = str.Substring(str.IndexOf(symbol));
            //    Console.WriteLine(result);
            //}
            //else {
            //    Console.WriteLine("Symbol not found!");
            //}

            //string str = " Hello World!    ";
            //string result = str.Trim(' ');

            //Console.WriteLine($"*{str}*");
            //Console.WriteLine($"*{result}*");

            //char symbol1 = 'a';
            //char symbol2 = '0';

            //Console.WriteLine(char.IsDigit(symbol1));
            //Console.WriteLine(char.IsDigit(symbol2));
        }
    }
}