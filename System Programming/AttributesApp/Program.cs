using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using AttributesApp.Attributes;

[MyCustom(100)]
public class Program
{
    // [MyCustom]
    public int MyProperty { get; set; }

    [MyCustom(777, Message = "Hello World!")]
    public static void MyMethod() {

    }
    

    private static void Main(string[] args)
    {
        // Expression<Func<int, string>> expression = (num) => num.ToString();

        // System.Console.WriteLine(expression.ToString());

        // var isVirtualMethod = methodInfo.Attributes.HasFlag(System.Reflection.MethodAttributes.Virtual);

        var methodInfo = typeof(Program)
            .GetMethod(nameof(MyMethod));

        object? attribute = methodInfo?.GetCustomAttributes(true).First();

        if(attribute is MyCustomAttribute myCustomAttribute) {
            System.Console.WriteLine(myCustomAttribute.Num);
            System.Console.WriteLine(myCustomAttribute.Message);
        }

        //System.Console.WriteLine(attribute);
    }
}