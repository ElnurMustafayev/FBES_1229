#include <iostream>

using namespace std;

class Person {
	int id;
	int age;
	bool showed = false;
	string name;

public:
	friend ostream& operator <<(ostream& stream, Person& p);
	friend class Test;

	static int idCounter;

	Person() {
		this->id = ++idCounter;
	}

	Person(int age, string name) : Person() {
		this->age = age;
		this->name = name;
	}

	int operator >>(Person other) {
		this->age -= other.age;
	}
};
int Person::idCounter = 0;

// friend class
class Test {
	Test(Person p)
	{
		p.age;
	}
};

// friend function
ostream& operator <<(ostream& stream, Person& p) {
	if (p.showed == false) {
		cout << "Id: #" << p.id << endl;
		cout << "Name: " << p.name << endl;
		cout << "Age: " << p.age << " years" << "\n\n";

		p.showed = true;
	}

	return stream;
}


int main()
{
	Person p1 = Person(42, "Bob");
	Person p2 = Person(32, "Ann");

	cout << p1 << p2 << endl;
	cout << p1 << p2 << endl;
}