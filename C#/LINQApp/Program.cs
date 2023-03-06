using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

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

    static decimal ReturnDefaultValue2() => default;
    static decimal ReturnDefaultValue1() {
        return default;
    }
    static void Main() {

        // Any
        // All
        // Count
        // Min
        // Max
        // First
        // FirstOrDefault
        // Last
        // LastOrDefault
        // Sum
        // Average
        // Skip
        // Take
        // Where
        // Select

        IEnumerable<Person> people = new List<Person>() {
            new Person() {
                Name = "Kate",
                Age = 16,
                Gender = Gender.Female,
                IsMarried = false,
                Marks = new int[] {3,6,3,10},
            },

            new Person() {
                Name = "Zabil",
                Age = 29,
                Gender = Gender.Male,
                IsMarried = true,
                Marks = new int[] {12,11,10,12},
            },

            new Person() {
                Name = "Bob",
                Age = 45,
                IsMarried = false,
                Gender = Gender.Unknown,
                Marks = new int[] {10, 9, 7, 5},
            },

            new Person() {
                Name = "Samra",
                Age = 18,
                IsMarried = false,
                Gender = Gender.Female,
                Marks = new int[] {12, 10, 12, 9},
            },

            new Person() {
                Name = "Arkhun",
                Age = 15,
                IsMarried = false,
                Gender = Gender.Male,
                Marks = new int[] {9, 9, 12, 10},
            },

            new Person() {
                Name = "Ann",
                Age = 17,
                IsMarried = true,
                Gender = Gender.Female,
                Marks = new int[] {12, 12, 12, 12},
            },
        };


        //bool containsAdult = people.Any(person => person.Age >= 18);
        //bool allAreAdult = people.All(p => p.Age >= 18);
        //Console.WriteLine(allAreAdult);

        //Console.WriteLine($"Count: {people.Count()}");

        //int count = people.Count(p => p.Age >= 18 && p.IsMarried);

        //count = people.Count(p => {
        //    if(string.IsNullOrWhiteSpace(p.Name)) {
        //        return false;
        //    }
        //    else if (p.Name.Length < 5) {
        //        return false;
        //    }
        //    else {
        //        return p.Name[4] == 'a';
        //    }
        //});

        //count = people.Count(p => p.Gender == Gender.Unknown || p.Gender == Gender.Other);

        //Console.WriteLine(count);

        //var minAge = people.Min(p => p.Age);
        //var maxAge = people.Max(p => p.Age);
        //
        //Console.WriteLine(minAge);
        //Console.WriteLine(maxAge);

        //var personMin = people.Min();
        //var personMax = people.Max();

        //Console.WriteLine(personMin.Name);
        //Console.WriteLine(personMax.Name);


        //var found = people.FirstOrDefault(p => p.Age == 19);
        //found = people.LastOrDefault(p => p.Gender == Gender.Female);
        //if (found == null) {
        //    Console.WriteLine("Person not found!");
        //}
        //else {
        //    Console.WriteLine($"Found person's name: {found.Name}");
        //}

        //var allAges = people.Sum(p => p.Age);
        //var avgAge = (int)people.Average(p => p.Age);
        //Console.WriteLine(allAges);
        //Console.WriteLine(avgAge);

        //var result = people.Skip(2).Take(2).Skip(0);
        //
        //foreach (var person in result) {
        //    Console.WriteLine(person.Name);
        //}

        //var adults = people.Where(p => p.Age >= 18);
        //var founds = people.Where(p => p.Age < 18 && p.IsMarried);

        //foreach (var person in founds) {
        //    Console.WriteLine($"{person.Name}: {person.Age} years old");
        //}


        // get avg age of marrieds
        //var avgAgeOfMarrieds = people
        //    .Where(p => p.IsMarried)
        //    .Average(p => p.Age);

        //Console.WriteLine(avgAgeOfMarrieds);


        //var avgMark = people
        //    .Select(p => p.Marks.Average())
        //    .Average();

        //Console.WriteLine($"Avg mark is {avgMark}");

        //var goodStudents = people
        //    .Where(p => p.Marks.Average() >= avgMark);

        //foreach (var student in goodStudents) {
        //    Console.WriteLine(student.Name);
        //}





        //IEnumerable<int> collection = new List<int>() {
        //    12,5,15,45,7,43,23,575,714,5
        //};

        //Console.WriteLine($"Min: {collection.Min()}");
        //Console.WriteLine($"Max: {collection.Max()}");

        //var result = collection.Any((num) => new Random().Next(0, 10) == 5);

        //var result = collection.All(num => num % 5 == 0);

        //Console.WriteLine(result);



























        // anonimous function
        if (false) {

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