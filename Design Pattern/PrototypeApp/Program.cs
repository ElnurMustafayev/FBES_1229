namespace PrototypeApp;

public class Program {
    static void Main() {
        var enemyPrototype1 = new User() {
            Name = "Zombie",
            Surname = string.Empty,
        };

        var enemyPrototype2 = enemyPrototype1.Clone();
        enemyPrototype2.IdInfo.Id += 1;

        Console.WriteLine(enemyPrototype1); // id = 0
        Console.WriteLine(enemyPrototype2); // id = 1
    }
}