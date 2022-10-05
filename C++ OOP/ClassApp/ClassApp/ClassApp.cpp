#include <iostream>

using namespace std;

enum GENDERS : int {
	male, 
	female,
	other,
	unknown
};


class Person {
public:
	char* name;
	char* surname;
	int age = -1;

	GENDERS gender = GENDERS::unknown;

	void Show(Person p) {
		cout << "name: " << p.name << endl;
		cout << "surname: " << p.surname << endl;
		cout << "age: " << p.age << endl;
		cout << "gender: " << p.gender << endl;
	}
};


//struct Car {
//public:
//	int productionYear;
//private:
//	double speed;
//public:
//private:
//	char* name;
//};



//int Sum(Calc calc) {
//	return calc.num1 + calc.num2;
//}
//
//int Div(Calc calc) {
//	if (calc.num2 == 0)
//		throw "num2 can not be 0!";
//
//	return calc.num1 / calc.num2;
//}

class Calc {
public:
	int num1;
	int num2;

	int Sum(int x, int y) {
		return x + y;
	}

	int Div(int x, int y) {
		if (y == 0)
			throw "y can not be 0!";

		return x / y;
	}

	
	int Pow(int number, int power) {
		int result = 1;
		for (int i = 0; i < power; i++)
		{
			result *= number;
		}
		return result;
	}

	int Sqrt(int number) {
		for (double i = 1; i < (number / 2); i++)
			if (number / i == i)
				return i;

		return -1;
	}
};





int main()
{
	/*Calc myCalc;
	cout << myCalc.Pow(2, 5) << endl;
	cout << myCalc.Sqrt(100) << endl;*/

	/*Person obj = Person();
	obj.name = (char*)"Bob";
	obj.surname = (char*)"Marley";
	obj.age = 80;

	cout << obj.name << endl;
	cout << obj.surname << endl;
	cout << obj.age << endl;
	cout << obj.gender << endl;*/

	//Car car = Car();

	/*Calc myCalc;
	myCalc.num1 = 15;
	myCalc.num2 = myCalc.num1++;

	cout << Sum(myCalc) << endl;*/


	/*Calc myCalc;
	int result = myCalc.Sum(-10, 20);
	cout << result << endl;*/


	// Calc: Pow(num, power), Sqrt(121)


	/*Person obj = Person();
	obj.name = (char*)"Bob";
	obj.surname = (char*)"Marley";
	obj.age = 80;
	obj.gender = GENDERS::male;
	
	obj.Show(obj);*/
}