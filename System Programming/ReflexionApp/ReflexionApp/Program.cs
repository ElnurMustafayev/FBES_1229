namespace AssemblyApp;

using System.Reflection;

public class MyClass {
    public int num1 = 10;
    public decimal num2 = 0;
    public string str = "hello";

    public MyClass(int num) { }
    public MyClass(string str, bool flag) {
        Console.WriteLine($"Values: {str} {flag}");
    }

    //public MyClass() {
    //    Console.WriteLine("Default ctor called!");
    //}

    public void Func1(int num) {
        Console.WriteLine($"Hello World! num = {this.num1 + num}");
    }
    public bool Func2() => false;
}

public class Program {
    static void Func<T>() {
        object obj = Activator.CreateInstance(type: typeof(T), args: new object?[] { "test", false });

        //T obj = new T();
    }

    static void Main() {
        Type type = typeof(MyClass);

        if (false) {
            //object obj = Activator.CreateInstance(type);
            //Console.WriteLine(obj.GetType());
            //Console.WriteLine((obj as MyClass)?.num1);

            //MyClass obj = Activator.CreateInstance<MyClass>();
            ////MyClass obj = new MyClass();
            //Console.WriteLine(obj.GetType());
            //Console.WriteLine(obj.num1);

            Func<MyClass>();
        }



        if (false) {
            //ConstructorInfo[] ctors = type.GetConstructors();

            //foreach (var ctor in ctors) {
            //    ParameterInfo[] parameters = ctor.GetParameters();

            //    foreach (var parameter in parameters) {
            //        Console.Write(parameter.Name + " ");
            //    }
            //    Console.WriteLine();
            //}


            //var parameterlessCtor = type.GetConstructors()
            //    .First(ctor => ctor.GetParameters().Any() == false);

            //parameterlessCtor.Invoke(null);

            //MethodInfo[] s = type.GetMethods();
            //var a = s.First(method => method.Name == "Func1");

            //MyClass obj = new MyClass();
            //object? d = a.Invoke(obj, new object[] { 100 });

            //Console.WriteLine(d == null);
        }

        if (false) {
            MemberInfo[] members = type.GetMembers();

            foreach (var member in members) {
                Console.WriteLine($"{member.Name} - {member.MemberType} - {member.DeclaringType?.FullName}");
            }
        }

        if (false) {
            FieldInfo[] fields = type.GetFields();

            foreach (var field in fields) {
                Console.WriteLine(field.FieldType);
            }
        }

        if (false) {
            //MyClass obj = new MyClass();
            //Type type = obj.GetType();
        }
    }
}