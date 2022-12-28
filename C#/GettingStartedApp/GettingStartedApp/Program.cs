namespace App {
    class Program {
        static void Main() {
            /*
            int i = -1230;
            uint ui = 0;

            long l = 31254315652364125;
            short s = 30000;
            byte _b = 123;

            double d = 123.456;
            char c = 'a';
            bool b = false;
            string str = "test";
            */

            //float f1 = 123.456f;
            //float f2 = (float)123.456;
            //float f3 = 123;

            //decimal d = 123.456324234234m;
            //Console.WriteLine(d);

            //int num = 123;
            //num += 27;
            //int a = 2;
            //num *= a++;
            //Console.WriteLine(num + a);

            //int num = 333;
            //num /= 111;
            //num = ++num * num;
            //Console.WriteLine(num);


            //char a = 'a';
            //char b = 'b';

            //Console.WriteLine(a + b);

            //Console.WriteLine("Hello, " + Console.ReadLine() + " " + Console.ReadLine() + "!");


            //int age = 53;
            //string name = "Bob";

            //Console.WriteLine("Age: " + age + " years old");
            //string text = string.Format("Name: {0}. Age: {1} years old", name, age);
            //Console.WriteLine(text);


            //string username = "Arkhun";
            //double spendMoney = 42_000;
            //string currency = "rub";
            //string productType = "usluqi dla Tamerlana";

            //string logText = $"User '{username}' spend {spendMoney} {currency} for '{productType}'.";
            //Console.WriteLine(logText);



            //string heightStr = Console.ReadLine();

            //string str = "123";
            //int num = Convert.ToInt32(str);

            //Console.WriteLine(num);            //string heightStr = Console.ReadLine();

            //string str = "123";
            //int num = Convert.ToInt32(str);

            //Console.WriteLine(num);



            // height
            // m sm
            // "Your height: Xm Ysm"


            Console.Write("Input your height (sm): ");  // 178
            string heightStr = Console.ReadLine();

            int height = Convert.ToInt32(heightStr);

            int m = height / 100;
            int sm = height % 100;

            Console.WriteLine($"Your height is: {m}m {sm}sm");
        }
    }
}