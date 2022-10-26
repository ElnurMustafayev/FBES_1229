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



void Func() {
	cout << "Start" << endl;

	if (true) {
		Person p = Person();

		cout << p.age << endl;
	}
	cout << "End" << endl;
}




class Car {
public:
	double maxSpeed;
	string model;

	Car(double maxSpeed, string model) {
		this->maxSpeed = maxSpeed;
		this->model = model;
	}

	~Car() {
		cout << "Destructor" << endl;
	}
};







class Test {
public:
	int* arr;

	Test() {
	}

	~Test() {
		cout << "Destructor" << endl;
	}
};



int* ptr;


void ShowMemory() {
	for (int i = -10; i < 10; i++)
	{
		cout << "0x" << (ptr + i) << "\t" << *(ptr + i) << endl;
	}

	cout << "\n\n\n";
}



Test GetObject() {
	Test obj = Test();

	int arr[5]{
		1,2,3,4,5
	};

	ptr = arr;

	obj.arr = arr;
	
	//cout << "Before: " << endl;
	//ShowMemory();

	return obj;
}

int main() {
	/*Test temp = Test();

	
	temp = GetObject();

	cout << "After: " << endl;*/
	//ShowMemory();

	/*cout << temp.arr[0] << endl;
	cout << temp.arr[1] << endl;
	cout << temp.arr[2] << endl;
	cout << temp.arr[3] << endl;
	cout << temp.arr[4] << endl;*/


	/*cout << "Start" << endl;

	Car* car1 = new Car(360, "BMW M5");
	delete car1;

	Car car2 = Car(360, "BMW M5");
	car2.~Car();

	cout << "End" << endl;*/


	/*Func(10, 15);
	Func(10);*/


	/*{
		Person p3 = Person("Bob", 7);
		Person p4 = Person();
	}

	ShowPeopleInfo();*/
}