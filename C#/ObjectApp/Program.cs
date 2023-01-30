using System.Collections.Specialized;

namespace ObjectApp;

class Person {
    public string Name { get; set; } = "Unknown";
    private static int idCounter = 0;
    private int id;

    public Person() {
        this.id = ++idCounter;
    }

    public Person(string name) : this() {
        Name = name;
    }

    public override int GetHashCode() {
        return this.id;
    }

    public override string ToString() {
        return @$"Name: {this.Name}
Id: {this.id}";
    }
}

class Car {
    public string model;
    public double maxSpeed;

    public Car(string model, double maxSpeed) {
        this.model = model;
        this.maxSpeed = maxSpeed;
    }

    public override bool Equals(object? obj) {
        //Car car1 = (obj as Car);
        //Car car2 = (Car)obj;
        //Console.WriteLine(car1.model);
        //Console.WriteLine(car2.model);

        if(obj is Car) {
            return this.maxSpeed == (obj as Car).maxSpeed;
        }

        return base.Equals(obj);
    }
}
    
class Program {

    static T GetObject<T>(object obj) where T: class {
        return obj as T;
    }

    static void PrintObject(object obj) {
        Console.WriteLine(obj is int);
        Console.WriteLine(obj);
    }

    static void Main() {
        if(true) {
            int num = 123;
            PrintObject(num);
        }


        if(false) {
            var result = GetObject<Car>(new Car("Porsche", 300));
            //Console.WriteLine(result.model);

            //int num = 123;
            //string str = "123";

            //object obj = num;
            //obj = str;

            ////int numm = (int)obj;
            //int numm = (int)obj;
            //Console.WriteLine(numm);
        }


        if(false) {
            //int num = 0xAA123;
            //Console.WriteLine(num);

            //Car car1 = new Car("Porsche", 300);
            //Car car2 = car1;

            //Console.WriteLine(car1.GetHashCode());
            //Console.WriteLine(car2.GetHashCode());

            //Car car1 = new Car("Porsche", 300);
            //Car car2 = new Car("Porsche", 300);

            //car1.Equals(123);
            //car1.Equals(new Person());
            //car1.Equals(car1);
            //car1.Equals(car2);
            //Console.WriteLine(car2.Equals(new Car("Bmw", 300)));




            //int num = 123;
            //int _num = 777;
            //Console.WriteLine(num.Equals(num));
            //Console.WriteLine(num.Equals(123));

            //Console.WriteLine(_num.Equals(_num));
            //Console.WriteLine(num.Equals(num));
            //Console.WriteLine(num.Equals(777));


            //Car car1 = new Car("Porsche", 300);
            //Car car2 = new Car("Bmw", 280);
            //Car car3 = new Car("Porsche", 300);

            //Console.WriteLine(car1.Equals(123));
            //Console.WriteLine(car1.Equals(car2));
            //Console.WriteLine(car1.Equals(car3));

            //Console.WriteLine(car1.Equals(car1));
            //car3 = car1;
            //Console.WriteLine(car1.Equals(car3));
        }

        if (false) {
            object[] universanArray = {
                123,
                true,
                new List<Person>(),
                new Person("Bob"),
                new Person(),
                "qwe",
            };

            for (int i = 0; i < universanArray.Length; i++) {
                Console.WriteLine(universanArray[i]);
            }


            //object obj;

            //obj = 132;
            //obj = "qweqwe";
            //obj = true;
            //obj = new Person();
        }


        if(false) {
            Person p1 = new Person("Elnur");
            var result = p1.ToString();

            Console.WriteLine(new Person("Arkhun"));

            Console.WriteLine(result);
            Console.WriteLine(DateTime.Now);
        }

        if(false) {
            Person p1 = new Person();
            Console.WriteLine(p1.GetHashCode());

            Person p2 = new Person();
            Console.WriteLine(p2.GetHashCode());

            Person p3 = new Person();
            Console.WriteLine(p3.GetHashCode());
        }
    }
}