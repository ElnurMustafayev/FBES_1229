using System;
using System.Reflection.Metadata.Ecma335;

namespace LINQApp;

class Program {
    //static IEnumerable<T> Add<T>(IEnumerable<T> collection, T newEl) {
    //    return collection.Append(newEl);
    //}

    static void MethodForAction1() {
        Console.WriteLine("I am action method!");
    }

    static void MethodForAction2(int num1, decimal num2) {
        Console.WriteLine($"{num1} {num2}");
    }

    static void PrintElement(int num) => Console.WriteLine(num > 0);
    static bool CheckNumberIsPositive(int num) => num > 0;
    static bool CheckNumberDivisableBy5(int num) => num % 5 == 0;

    static decimal MethodForFunctor1(int test) => 0m;
    static string MethodForFunctor2(double num1, int num2) => $"{num1} {num2}";
    
    static int Func() => 0;

    static bool CheckContainsZero(int num) => num == 0;

    delegate void MyParametrizedDel<T>(T arg, int num);

    static void Main() {
        // anonimous function
        if(false) {

            Action action = new Action(delegate () {
                Console.WriteLine("Big");
            });
            action += delegate () {
                Console.WriteLine("Medium");
            };

            // lambda expression
            action += () => {
                Console.WriteLine("Small");
            };
            action += () => Console.WriteLine("Very Small");

            action();

        }

        if(false) {
            Action<int> action = delegate (int num) {
                Console.WriteLine($"1, {num}");
            };

            action += (num) => Console.WriteLine($"2, {num}");

            action(15);
        }

        if(false) {
            Action<double, float, int> action = (d, f, i) => Console.WriteLine($"{d}{f}{i}");

            MyParametrizedDel<string> del = delegate (string str, int num) {
                Console.WriteLine($"{str} - {num}");
            };

            del += (str, num) => Console.WriteLine($"{str} + {num}");

            //del("Test", 100);
            action(1, 1, 1);
        }

        if(false) {
            Func<int, string> func = delegate (int num) { return $"{num}"; };
            func += (num) => { return $"{num}"; };
            func += (num) => $"{num}";
            func += num => $"{num}";
        }

        if(false) {
            Predicate<int> checkIsPositive = num => num >= 0;

            Console.WriteLine(checkIsPositive(10));
            Console.WriteLine(checkIsPositive(0));
            Console.WriteLine(checkIsPositive(-10));
        }


        //IEnumerable<int> nums = new int[] {
        //    -123,35,-12,4,34646,23513,35,0,352,-6
        //};
        
        //nums.Any();

        //Console.WriteLine(nums.MyAny());
        //nums.Any(CheckContainsZero);




        // FUNC
        //IEnumerable<int> nums = new List<int> { 22, 1, -3, 32, 0, -66, };
        //Func<int, decimal> func1 = MethodForFunctor1;
        //Func<double, int, string> func2 = MethodForFunctor2;
        //nums.Where()



        // PREDICATE
        //List<int> nums = new List<int>{ 22, 1, -3, 32, 11, -66, };

        //Predicate<int> predicate = CheckNumberIsPositive;

        ////var exists = nums.Exists(predicate);
        //var exists = nums.Exists(CheckNumberDivisableBy5);
        ////var contains = nums.Contains(22);

        //Console.WriteLine(exists);



        // ACTION
        //List<int> nums = new List<int>{ 22, 1, -3, 32, 0, -66, };

        //Action action = MethodForAction;
        //action.Invoke();

        //Action<int, decimal> action = MethodForAction2;

        //nums.ForEach(PrintElement);












        //var resultCollection = Add(Add(new int[] { 1, 2, 3 }, 4), 5);



        //int[] nums = { 1, 2, 3 };
        //var resultCollection = nums.Append(4);

        //foreach (var item in resultCollection) {
        //    Console.WriteLine(item);
        //}
    }
}