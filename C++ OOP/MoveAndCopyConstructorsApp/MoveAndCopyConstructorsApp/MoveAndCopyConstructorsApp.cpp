#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;




class Person {
public:
	char* name = nullptr;
	int age = 0;
	bool isMarried = false;

	Person(int age, char name[])
	{
		cout << "CTOR"<< endl;
		this->age = age;

		int length = strlen(name);
		this->name = new char[length + 1];
		for (int i = 0; i < length; i++)
		{
			this->name[i] = name[i];
		}
		this->name[length] = '\0';
	}

	void operator = (const Person& otherPerson) {
		memcpy(this, &otherPerson, sizeof(Person));
		//this->age = otherPerson.age;

		int length = strlen(otherPerson.name);
		this->name = new char[length + 1]{};

		for (int i = 0; i < length; i++)
		{
			this->name[i] = otherPerson.name[i];
		}

		this->name[length] = '\0';
	}

	//Person(const Person& otherPerson) : Person(otherPerson.age, otherPerson.name) {}
	
	Person(const Person& otherPerson) {
		memcpy(this, &otherPerson, sizeof(Person));
		//this->age = otherPerson.age;

		int length = strlen(otherPerson.name);
		this->name = new char[length + 1]{};

		for (int i = 0; i < length; i++)
		{
			this->name[i] = otherPerson.name[i];
		}

		this->name[length] = '\0';
	}

	Person(Person&& otherPerson) {
		cout << "MOVE" << endl;

		memcpy(this, &otherPerson, sizeof(Person));
		//this->age = otherPerson.age;
		//this->name = otherPerson.name;

		otherPerson.name = nullptr;
	}

	~Person() {
		cout << "DESTR" << endl;

		if(this->name != nullptr)
			delete[] this->name;
	}

	void Info() {
		cout << "Name: " << this->name << endl;
		cout << "Age: " << this->age << endl;
	}
};





class MyClass {
public:
	int num = 0;

	MyClass() {
		cout << "CTOR" << endl;
	}
	MyClass(const MyClass& obj) {
		cout << "COPY" << endl;

		memcpy(this, &obj, sizeof(obj));
	}
	MyClass(MyClass&& obj) {
		cout << "MOVE" << endl;
	}
};



MyClass GetObject() {
	MyClass obj = MyClass();	// CTOR
	return obj;					// MOVE
}

void Func(MyClass obj) {}		// COPY


Person GetPerson(int age) {
	char name[] = "Test";
	Person p = Person(age, name);
	return p;
}



int main()
{
	char name1[] = "Bob";
	Person p1 = Person(12, name1);

	char name2[] = "Kate";
	Person p2 = Person(14, name2);

	p1 = p2;


	//Person p = GetPerson(5);



	//MyClass obj = GetObject();	// MOVE
	//Func(obj);					// COPY

	/*
	char name[] = "Bob";
	Person p1(20, name);

	{
		Person p2 = p1;

		p2.Info();
	}

	p1.Info();
	*/



	/*
	MyClass obj1 = MyClass();
	obj1.num = 888;

	MyClass obj2 = obj1;

	cout << obj1.num << endl;
	cout << obj2.num << endl;
	*/



	/*
	MyClass obj1 = MyClass();

	MyClass obj2 = MyClass();
	obj2.num = 777;

	memcpy(&obj1, &obj2, sizeof(MyClass));

	cout << obj1.num << endl;
	cout << obj2.num << endl;
	*/



	/*
	int num1 = 0;

	int num2 = 777;

	memcpy(&num1, &num2, sizeof(num1));

	cout << num1 << endl;
	*/



	/*
	MyClass obj1 = MyClass();
	obj1.num = 1;
	
	MyClass obj2 = obj1;

	cout << obj2.num << endl;
	*/
}