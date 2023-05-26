namespace DynamicApp;

class User {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Firstname { get; set; }
    public string? Surname { get; set; }

    public User(string? firstname, string? surname) {
        this.Firstname = firstname;
        this.Surname = surname;
    }
}

public class Program {

    static object ObjectMethod(int num) {
        if(num % 2 == 0) {
            return new User("Elnur", "Mustafayev");
        }
        return 123;
    }

    static dynamic DynamicMethod(int num) {
        if (num % 2 == 0) {
            return new User("Elnur", "Mustafayev");
        }
        return 123;
    }

    static void Main() {
        //dynamic obj = 123;
        //Console.WriteLine(obj.GetType());
        //obj = "123";
        //Console.WriteLine(obj.GetType());



        //dynamic obj = new User("Elnur", "Mustafayev");
        //if(true) {
        //    Console.WriteLine(obj.Name);
        //}

        //Console.WriteLine(ObjectMethod(123).ToString());
        //try {
        //    Console.WriteLine(DynamicMethod(123).Firstname);
        //}
        //catch(Exception ex) {
        //    Console.WriteLine(ex.Message);
        //}

        //Console.WriteLine(DynamicMethod(125) is int);

        //User user = DynamicMethod(125);

        //Console.WriteLine(user.Firstname);

        //dynamic num = 123;
        //num.SalamAleykum();
    }
}