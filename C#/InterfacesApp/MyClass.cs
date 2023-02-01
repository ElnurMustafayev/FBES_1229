using InterfacesApp.Animals.Interfaces;

namespace InterfacesApp;

class MyClass : IMyInterface {
    public void MyMethodFromInterface(string arg) {
        //throw new NotImplementedException();

        Console.WriteLine("MyClass Implementation");
    }

    public bool MySecondMethod() {
        return false;
    }
}

struct MyStruct : IMyInterface {
    public void MyMethodFromInterface(string arg) {
        //throw new NotImplementedException();

        Console.WriteLine("MyStruct Implementation");
    }

    public bool MySecondMethod() {
        return true;
    }
}

//class Animal : IAnimal {

//}