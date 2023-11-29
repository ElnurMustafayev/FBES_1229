namespace AttributesApp.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class MyCustomAttribute : Attribute {
    public string? Message { get; set; }
    public readonly int Num;
    public MyCustomAttribute(int num)
    {
        this.Num = num;
    }
}