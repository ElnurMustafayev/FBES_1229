#include <iostream>

using namespace std;
class MyClass {
	int age;
	bool check;
public:

	MyClass(int num)
	{
		MyClass(10 > 78, "test");
		cout << "A" << endl;
	}

	MyClass(int num) : MyClass(10 > 78, "test")
	{
		cout << "A" << endl;
	}




	MyClass(bool check, const char* word) 
	{
		this->age = 100;
	}
};


//MyClass obj = MyClass(123);





//class Person {
//	int age = 180;
//	char symbol1 = '@';
//	short symbol1wr = 3252;
//	char symbol2 = 'Z';
//} p1;

int main()
{	
	/*bool* ptr = (bool*)&p1;

	for (int i = 0; i < sizeof(Person); i++)
	{
		cout << *(ptr + i) << endl;
	}*/


	/*int* ptr = (int*)&p1;

	cout << *(ptr) << endl;*/

	MyClass obj = MyClass(123);

}