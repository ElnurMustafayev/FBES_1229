namespace App;

public partial class MyClass {
    public int num1;
}

public partial class MyClass {
    public int num2;
}

public partial class MyClass {
    public int num3;
}

public class Program {
    public static void Main() {
        MyClass obj = new MyClass();
        obj.num1 = 111;
        obj.num2 = 222;
        obj.num3 = 333;

        Console.WriteLine(obj.num1);
        Console.WriteLine(obj.num2);
        Console.WriteLine(obj.num3);
    }
}