//var result = Math.Pow(3, 3);
//Console.WriteLine(Math.Abs(-10));
//Console.WriteLine(Math.Abs(10));
//Console.WriteLine(Math.Min(45, 78));
//Console.WriteLine(Math.Sqrt(45));
//Console.WriteLine(Math.Floor(1.7));
//Console.WriteLine(Math.Ceiling(1.7));
//Console.WriteLine(Math.Round(1.5));
//Console.WriteLine(Math.PI);



//Random randomizer = new Random();
//for (int i = 0; i < 100; i++) {
//    int result = randomizer.Next(-5, 5); // [from, to)
//    Console.Write(result + " ");
//}

//var datetime = DateTime.Now;
//Console.WriteLine(datetime);




//var datetime = DateTime.Now;

//datetime = datetime.AddDays(103);
//datetime = datetime.AddMonths(3);
//datetime = datetime.AddYears(30);
//datetime = datetime.AddYears(-2050);

//if(datetime.DayOfWeek == DayOfWeek.Friday) {
//    Console.WriteLine("Go to sleep!");
//}
//else {
//    Console.WriteLine("Work hard");
//}

//Console.WriteLine(datetime);

//var datetime = new DateTime(2008, 1, 14);
//Console.WriteLine(datetime.DayOfYear);
//Console.WriteLine(datetime.DayOfWeek);

//var date = DateTime.Now;
//date = date.AddDays(new Random().Next(-30, 31));

//Console.WriteLine(date);



//var ArhunBd = new DateTime(2008, 1, 14);
//var TamerlanBd = new DateTime(2008, 2, 15);

//var result = TamerlanBd - ArhunBd;

//Console.WriteLine(result.TotalMilliseconds);

















// using Microsoft.VisualBasic;

// namespace OopInCsharpApp {
//     class Program {
//         static int ReadNumber(string message) {
//             Console.Write($"{message}: ");
//             int result;
//             while (int.TryParse(Console.ReadLine(), out result) == false) { }
//             return result;
//         }

//         static void Main() {
//             // year, month, day
//             var date = new DateTime(
//                 year: ReadNumber("Year"),
//                 month: ReadNumber("Month"),
//                 day: ReadNumber("Day"));

//             Console.WriteLine(date.DayOfWeek);

//             while(date.DayOfWeek != DayOfWeek.Monday) {
//                 date = date.AddDays(-1);
//             }

//             for (int i = 0; i < 7; i++) {
//                 Console.WriteLine($"{date.DayOfWeek} - {date.ToShortDateString()}");
//                 date = date.AddDays(1);
//             }
//         }
//     }
// }