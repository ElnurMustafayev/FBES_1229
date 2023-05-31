void Func<T>() {
    var type = typeof(T);
    Console.WriteLine(type.FullName);
}

Func<System.Text.RegularExpressions.Regex>();
Console.WriteLine(typeof(int).Namespace);