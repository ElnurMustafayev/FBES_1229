#include <iostream>

using namespace std;

class Hero {
public:
	int defence = 10;
	int attack = 10;
	char* name;

	Hero(int attack)
	{
		this->attack = attack;
	}

	void ShowInfo() const {
		cout << "Defence: " << this->defence << endl;
		cout << "Attack: " << this->attack << endl;
	}
};




class Int {
	int num;

public:
	explicit Int(int num)
	{
		cout << "CTOR" << endl;
		this->num = num;
	}

	Int(int* num)
	{
		cout << "CTOR" << endl;
		this->num = *num;
	}

	int Value() {
		return this->num;
	}

	bool IsPositive() {
		return this->num >= 0;
	}
};



class Car {
	int speed;
	mutable int gettersCallingCounter = 0;

public:
	int getSpeed() const {
		//this->setSpeed(12312);
		this->gettersCallingCounter++;
		return this->speed;
	}

	void setSpeed(int speed) {
		this->gettersCallingCounter++;
		this->speed = speed;
	}
};

int main()
{
	/*Hero h = 12;

	h.ShowInfo();*/

	/*Int num = -234235;
	cout << num.IsPositive() << endl;*/

	/*Int num = 123;
	num = 1243523;

	cout << num.Value() << endl;*/

	//int num1 = 123;
	//int num2 = int(123);

	/*Int num = Int(123);
	Int num = new int(123);*/

	/*Car car = Car();

	car.setSpeed(100);
	cout << car.getSpeed() << endl;*/



}