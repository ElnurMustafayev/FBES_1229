using static System.Net.Mime.MediaTypeNames;

namespace FunctionsApp {
    class Program {
        //static void One() {
        //    Console.WriteLine("One");
        //}

        //static void Two() {
        //    Console.WriteLine("Two");
        //}

        //static void Three() {
        //    Console.WriteLine("Three");
        //}

        static void ShowNum(int num) {
            Console.WriteLine($"Num: '{num}'");
        }

        static void SplitString(string text, char separator) {
            if(string.IsNullOrEmpty(text)) {
                Console.WriteLine("Text is empty!");
                return;
            }

            string[] parts = text.Split(separator);

            Console.WriteLine($"Parts count: {parts.Length}");
        }
        static bool IsDigit(string str, char trimParameter = ' ') {
            str = str.Trim(trimParameter);

            if (string.IsNullOrWhiteSpace(str))
                return false;

            for (int i = 0; i < str.Length; i++) {
                if (char.IsDigit(str[i]) == false)
                    return false;
            }

            return true;
        }

        static void ChangeNum(int num) {
            num++;
            //Console.WriteLine(num);     // 778
        }

        static void ChangeNum(ref int num) {
            ++num;
        }

        static void ChangeArr(int[] arr) {
            arr[0] = 55;
        }

        static void PrintArr(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        static void Main() {
            int num = 0;
            ChangeNum(num);
            ChangeNum(ref num);
            ChangeNum(ref num);
            ChangeNum(num);
            ChangeNum(ref num);
            Console.WriteLine(num);






            // reference types
            //int[] nums1 = { 1, 2, 3, 4, 5 };
            //int[] nums2 = { 45, 67, 89 };

            //nums2 = nums1;

            //nums2[0] = 99;

            //Console.WriteLine(nums1[0]);
            //Console.WriteLine(nums2[0]);



            // value types
            //int num1 = 10;
            //int num2 = 15;

            //num1 = num2;

            //++num1;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);




            //int num = 777;
            //ChangeNum(num);
            //Console.WriteLine(num);     // 777

            //Console.WriteLine("\n\n\n");

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //ChangeArr(nums);
            //PrintArr(nums);



            //Console.WriteLine(IsDigit("12345"));        // true
            //Console.WriteLine(IsDigit(" "));            // false
            //Console.WriteLine(IsDigit(" 123"));         // true
            //Console.WriteLine(IsDigit("123k", 'k'));    // true
            //Console.WriteLine(IsDigit(""));             // false

            //SplitString("Hello World!", 'l');

            //Console.WriteLine("Hello World!".Split('o').Length);

            //int num = 100;
            //ShowNum(num);

            //ShowNum(200);


            //while(true) {
            //    Console.Clear(); 
            //    Console.Write("Input sumbol: ");
            //    char key = (char)Console.Read();

            //    switch (key) {
            //        case '1':
            //            One();
            //            break;
            //        case '2':
            //            Two();
            //            break;
            //        case '3':
            //            Three();
            //            break;
            //        default:
            //            continue;
            //    }
            //    break;
            //}
        }
    }
}