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
    
    static void Main() {
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