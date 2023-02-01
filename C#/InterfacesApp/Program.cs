using InterfacesApp.Animals;
using InterfacesApp.Animals.Interfaces;

namespace InterfacesApp;

class Program {

    //static void AskToFly(IAnimal animal) {
    //    animal.Fly();
    //}

    static void Main() {
        if(true) {
            List
            Parrot parrot = new Parrot("Cucumber");
            Cat cat = new Cat("Rijik");
            Shark shark = new Shark();

            //Animal[] animals = {
            //    parrot, cat, shark
            //};

            //IAnimal animal = parrot;
            //animal.Fly();

            ISwimable[] animals = {
                cat, shark, new RoboCat("ROBO") //parrot,
            };

            for (int i = 0; i < animals.Length; i++) {
                var currentAnimal = animals[i];
                currentAnimal.Swim();
            }
        }

        if(false) {
            MyClass obj1 = new MyClass();
            obj1.MyMethodFromInterface("123");
            Console.WriteLine(obj1.MySecondMethod());

            MyStruct obj2 = new MyStruct();
            obj2.MyMethodFromInterface("123");
            Console.WriteLine(obj2.MySecondMethod());
        }
    }
}