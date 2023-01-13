namespace TemplateFunctionsApp {
    class Program {
        //template<typename T>
        //static void Func<T>(T variable) {
        //    Console.WriteLine(typeof(T).Name);
        //}

        //static void Func<T>() {
        //    Console.WriteLine(typeof(T).Name);
        //}

        //static T Func<T>(T arg1, T arg2) {
        //    //T result = arg1 + arg2;       // error

        //    Console.WriteLine(arg1);
        //    Console.WriteLine(arg2);

        //    return arg2;
        //}

        ////template<typename T1, typename T2, typename T3, typename T4>
        //static T4 MyFunc<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3) {
        //    Console.WriteLine(typeof(T1).Name);
        //    Console.WriteLine(typeof(T2).Name);
        //    Console.WriteLine(typeof(T3).Name);

        //    T4 variable = default;

        //    return variable;
        //}

        static void MyFunc<T>(T variable) {
            Console.WriteLine(variable);
        }

        static void MyFunc(char variable) {
            Console.WriteLine($"CHAR: {variable}");
        }

        static void Main() {
            MyFunc(123);
            MyFunc('Q');

            //Func(123);
            //Func("qwerty");
            //Func<int[]>();

            //Console.WriteLine(Func(123, (int)312.45));

            //double variable = MyFunc<double, double, double, double>(123, 123, 123);
        }
    }
}