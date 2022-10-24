#include <iostream>

using namespace std;

class MyClass {
int* num = nullptr;
MyClass* objs = nullptr;

int lenght = 0;

public:
	/*void DeleteAll() {
		if(this->num)
			delete[] this->num;
		if (this->objs)
			delete this->objs;
	}*/

	MyClass(int num)
	{
		this->num = new int(num);
	}

	MyClass(int start, int end)
	{
		this->lenght = end - start;
		this->num = new int[this->lenght] {};

		for (int i = 0; i < this->lenght; i++)
		{
			this->num[i] = start + i;
		}
	}

	~MyClass()
	{
		cout << "Destructor" << endl;
	}

	void SayInfo() {
		if (this->lenght == 0) {
			//cout << "Number is: " << *num << endl;
		}
		else {
			for (int i = 0; i < this->lenght; i++)
			{
				//cout << "Number is: " << num[i] << endl;
			}
		}
	}
};

void Func(int num) {
	MyClass obj = MyClass(num);
	obj.SayInfo();

	//obj.DeleteAll();
}

void Func(int start, int end) {
	MyClass obj = MyClass(start, end);
	obj.SayInfo();

	//delete[] obj.GetArr();
	//obj.DeleteArr();
	//obj.DeleteAll();
}










class Person {
public:
	static int AllCount;
	static int AliveCount;
	static int DeadCount;

	string name;
	int age;

	Person(string name, int age) {
		this->name = name;
		this->age = age;
	}

	// CTOR
	Person()
	{
		AllCount++;
		AliveCount++;
	}

	// DTOR
	~Person()
	{
		AliveCount--;
		DeadCount++;
	}
};

int Person::AllCount = 0;
int Person::AliveCount = 0;
int Person::DeadCount = 0;



void ShowPeopleInfo() {
	cout << "All: " << Person::AllCount << endl;
	cout << "Alive: " << Person::AliveCount << endl;
	cout << "Dead: " << Person::DeadCount << endl;
}

int main() {
	/*Func(10, 15);
	Func(10);*/


	{
		Person p3 = Person("Bob", 7);
		Person p4 = Person();
	}

	ShowPeopleInfo();
}