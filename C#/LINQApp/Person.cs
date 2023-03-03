namespace LINQApp;

public enum Gender {
    Male, Female, Other, Unknown
}

public class Person : IComparable<Person> {
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsMarried { get; set; } = false;
    public Gender Gender { get; set; }
    public IEnumerable<int> Marks { get; set; }

    public int CompareTo(Person? other) {
        return (this.Age - other.Age);
    }
}