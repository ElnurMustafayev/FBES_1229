#include <iostream>

namespace Test1 {
	enum GENDERS : int  {
		Male, Female, Other
	};

	int num2 = 777;
	int num = 777;

	class MyClass {
	public:
		int num1;
	};
}

namespace Test2 {
	int num1 = 100;
	int num = 100;

	class MyClass {
	public:
		double num2;
	};
}

namespace Test3 {
}


using namespace Test1;
using namespace Test2;
using namespace std;

#include "Cars.h"

int main()
{
	//Test1::MyClass obj = Test1::MyClass();
	//cout << num2 << endl;

	cars::Car* car = new cars::Car(360, "BMW M5");

	car->ShowInfo();

	//GENDERS::Male;
}