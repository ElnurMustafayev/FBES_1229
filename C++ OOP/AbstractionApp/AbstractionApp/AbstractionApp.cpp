#include <iostream>

using namespace std;

class Animal {
public:
	string name;
	int age;

	Animal(string name, int age) : name(name), age(age) {}
	Animal() {}

	// Bad
	/*virtual void Say() {
		cout << name << " says: ..." << endl;
	}*/

	// Ok
	virtual void Say() = 0;
};

class Cat : public Animal {
public:
	Cat(string name, int age) : Animal(name, age) {}

	/*void Say() override {
		cout << name << " says: meow" << endl;
	}*/
};

class Dog : public Animal {
public:
	Dog(string name, int age) : Animal(name, age) {}

	/*void Say() override {
		cout << name << " says: huf" << endl;
	}*/
};


int main()
{
	/*Cat cat = Cat("animal", 7);
	Animal& animal = cat;*/

	//Animal* animal1 = new Cat("Rijik", 5);
	//Animal* animal2 = new Dog("Barsik", 7);
	//Animal* animal3 = new Animal("Unknown", 2);

	//animal1->Say();
	//animal2->Say();
	//animal3->Say();
}