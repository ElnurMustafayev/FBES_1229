namespace AssemblyApp;

using System.Collections;
using System.Reflection;

public interface IInterface {
    void Func();
}
public class MyClass { }
public class Person : MyClass { }
public class Test : MyClass, IInterface {
    public void Func() {
        Console.WriteLine("Test Class implementation");
    }
}
public struct MyStruct : IInterface, IEnumerable {
    public void Func() {
        Console.WriteLine("MyStruct Struct implementation");
    }

    public IEnumerator GetEnumerator() {
        throw new NotImplementedException();
    }
}

public class Program {
    static void Main() {
        if(false) {
            var allTypes = Assembly.GetCallingAssembly().GetTypes();

            var firstInterface = allTypes.First(type => type.IsInterface);
            Console.WriteLine(firstInterface);

            var obj = allTypes.First(type => type.GetInterface(firstInterface.Name) != null);

            IInterface result = Activator.CreateInstance(obj) as IInterface;
            result.Func();
        }

        if(false) {
            var typesWhichInplementsIInterface = Assembly.GetCallingAssembly()
                .GetTypes()
                //.Where(type => type.GetInterface("IInterface") is not null)
                //.Where(type => type.BaseType?.Name == "MyClass")
                .Select(type => type.FullName);

            Console.WriteLine(typesWhichInplementsIInterface.Count());
        }

        if(false) {
            var structType = Assembly.GetCallingAssembly()
                .GetTypes()
                .First(type => type.Name == "MyStruct");

            //foreach (var @interface in structType.GetInterfaces()) {
            //    Console.WriteLine(@interface.FullName);
            //} 

            Type? interfaceType = structType.GetInterface("IInterface1");
            Console.WriteLine(interfaceType);
        }

        if(false) {
            Assembly currentAssembly = Assembly.GetCallingAssembly();

            //Console.WriteLine(currentAssembly);

            Type[] types = currentAssembly.GetTypes();

            foreach (var type in types) {
                Console.WriteLine(type);
            }
        }
    }
}