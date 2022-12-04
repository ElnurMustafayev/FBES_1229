#include <iostream>
using namespace std;

#include "Incorrect Zoo.h"
#include "Correct Zoo.h"

//class Animal {
//public:
//    string name;
//
//    void PrintInfo() {
//        cout << "name: " << this->name << endl;
//    }
//
//    Animal() : Animal("Unknown") {};
//    Animal(string name) : name(name) {}
//};
//
//class Dog : public Animal {
//public:
//    int age = 0;
//
//    Dog() : Animal("Unknown") {}
//    Dog(string name) : Animal(name) {}
//};
//
//class Cat : public Animal {
//public:
//    int age = 0;
//
//    Cat() : Animal("Unknown") {}
//    Cat(string name) : Animal(name) {}
//};
//
//
//class MyClass {
//
//};


// BAD
/*
    void PrintAnimalName(Cat cat) {
        cout << "name: " << cat.name << endl;
    }

    void PrintAnimalName(Dog dog) {
        cout << "name: " << dog.name << endl;
    }
*/

//void PrintAnimalName(Animal animal) {
//    cout << "name: " << animal.name << endl;
//}
//
//ostream& operator << (ostream& out, Animal animal) {
//    return out << animal.name;
//}

using namespace CorrectZoo;

int main()
{

    Animal* animal = new Cat();

    animal->Say();
    animal->Animal::Say();


    /*
    Animal animal = Animal();
    Animal cat = Cat();

    cat.Say();
    */

    //animal.Say();



    /*Animal animals[] {
        Cat("Rijik"),
        Cat("Umka"),
        Cat("Leopild"),
        Dog("Arch"),
        Dog("Test"),
    };

    for (auto animal : animals)
    {
        cout << animal << endl;
    }*/



    /*PrintAnimalName(Cat("Rijik"));
    PrintAnimalName(Dog("Rex"));*/



    /*Animal animal1 = Dog();
    Animal animal2 = Cat();

    cout << animal1.name << endl;
    cout << animal2.name << endl;*/



    /*Zoo zoo = Zoo();

    zoo.ToFeed();*/
    
    /*
    Func(123);
    Func('a');
    Func(123, 'a');
    */
}
























/*
void Func(int num) {
    cout << "Func1" << endl;
}
int Func(char num) {
    cout << "Func2" << endl;
    return num;
}
int* Func(int num1, char s) {
    cout << "Func3" << endl;
    return nullptr;
}
*/