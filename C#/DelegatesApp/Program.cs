namespace DelegatesApp;

delegate void MyEasyDelegate();
delegate double MyHardcoreDelegate(string str, sbyte num);
delegate bool Checker<T>(T item);

class Program {

    static void ShowIf<T>(IEnumerable<T> collection, Checker<T> checker) {
        foreach (var item in collection) {
            if(checker.Invoke(item)) {
                Console.WriteLine(item);
            }
        }
    }

    static bool MyNumberChecker(int num) {
        return num >= 0;
    }

    static bool CheckName(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return false;
        }
        else if (name[0] != char.ToUpper(name[0])) {
            return false;
        }
        else {
            return true;
        }
    }

    static void Main() {
        if(true) {
            Checker<int> checker = MyNumberChecker;
            ShowIf(new int[] { 11, 55, -44, -88, 0, 99, 5 }, checker);
            ShowIf(new string[] { "Ann", "bob", "john", "Test" }, CheckName);
        }

        if(false) {
            MyHardcoreDelegate func = MyHardcoreMethod;
            Console.WriteLine(func.Invoke("Test", 123));
            Console.WriteLine(func.Invoke("   ", -55));
            Console.WriteLine(func.Invoke("qwertyuiop[", 0));
        }

        if(false) {
            MyEasyDelegate func = new MyEasyDelegate(MyMethod1);
            func.Invoke();
            func.Invoke();
            func.Invoke();

            func = MyMethod2;
            func.Invoke();
            func.Invoke();
            func.Invoke();
        }

        if (false) {
            MyEnumerableCollection col = new MyEnumerableCollection();

            Console.WriteLine("Loop start");
            foreach (var item in col) {
                Console.WriteLine(item);
            }
            Console.WriteLine("Loop end");

            Console.WriteLine("Loop start");
            foreach (var item in col) {
                Console.WriteLine(item);
            }
            Console.WriteLine("Loop end");
        }

        if(false) {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);

            foreach (var num in nums) {
                Console.WriteLine(num);
            }
        }
    }

    static double MyHardcoreMethod(string message, sbyte val) {
        //if(string.IsNullOrWhiteSpace(message)) {
        //    Console.WriteLine($"Message is empty!!!");
        //    return 0;
        //}
        Console.WriteLine($"{message}: '{val}'");
        return message.Length;
    }

    static void MyMethod1() {
        Console.WriteLine("MyMethod 1");
    }
    static void MyMethod2() {
        Console.WriteLine("MyMethod 2");
    }
}