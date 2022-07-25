#include <iostream>

using namespace std;

void Main()
{
	if (false) {
		char word[] = "qwerty";
		int nums[] = { 1,2,3 };

		cout << word << endl;
		cout << nums << endl;
	}

	if (false) {
		int number = 100;
		int* numberPtr = &number;

		cout << numberPtr << endl;
		cout << &number << endl;
	}

	if (false) {
		int num = 555;
		int* numPtr = &num;

		cout << numPtr << endl;
		cout << num << endl;
		cout << &num << endl;
		cout << *numPtr << endl;
	}

	if (false) {
		int number = 100;

		int* numberPtr = &number;

		*numberPtr = 25;
		*numberPtr += 25;
		*numberPtr = number * 2;

		cout << *numberPtr + number << endl;
	}

	if (false) {
		int number = 100;

		int* numberPtr1 = &number;
		int* numberPtr2 = &number;
		int* numberPtr3 = &number;

		*numberPtr1 += *numberPtr2 + *numberPtr3;

		cout << number << endl;
	}

	if (false) {
		int num = 100;

		int* numPtr = &num;

		*numPtr *= 2;

		*numPtr *= ++(*numPtr);

		cout << num << endl;
	}
}

void Method(int number) {
	number = 123;
}

void Func(int num) {
	num = 555;
}