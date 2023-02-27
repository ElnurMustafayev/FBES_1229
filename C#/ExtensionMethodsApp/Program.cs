using ExtensionMethodsApp.Extensions;

namespace ExtensionMethodsApp;

public class Program {
    //public static void Say(User user, string message) {
    //    Console.WriteLine($"{user.Name}: \"{message}\"");
    //}

    static void Main() {
        /*
            User user = new User("David", "Kashirskiy") {
                BirthDate = new DateTime(year: 2007, month: 12, day: 28),
            };

            //user.Info();

            //Program.Say(user, "Hello World!");
            user.Say(123);
            user.Say(DateTime.Now);
            user.Say("Hello World!");
            //
            IEnumerable<string> list = new List<string>() {
                "one", "two", "three"
            };
            user.Say("one", "two", "three");
        */

        //Method(1, 2, 3, 4);

        //MyCollection<int> myCollection = new MyCollection<int>() {
        //    Data = new List<int>() { 414,6,15,3,6 },
        //};
        //
        //int foundIndex = myCollection.GetIndexByValue(15);
        //Console.WriteLine(foundIndex);

        //int num = -45;
        //Console.WriteLine(num.IsPositive());


        //string str = "  test ";

        //string str = null;
        //Console.WriteLine(str.NeedToTrim('#'));             // false
        //Console.WriteLine("  test ".NeedToTrim());          // true
        //Console.WriteLine("test".NeedToTrim());             // false
        //Console.WriteLine("test*".NeedToTrim('*'));         // true
        //Console.WriteLine(" test  ".NeedToTrim('#'));       // false
        //Console.WriteLine("".NeedToTrim('#'));              // false

        MyCollection<int> myCollection = new MyCollection<int>() {
            Data = new List<int>() { 414, 6, 15, 3, 6 },
        };

        myCollection.Sum();
    }

    //public static void Method(int num, params int[] nums) {
    //    foreach (var item in nums) {
    //        Console.WriteLine(item);
    //    }
    //}
}