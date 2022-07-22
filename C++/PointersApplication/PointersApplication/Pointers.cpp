#include <iostream>
#include "Functions.h"

using namespace std;

int main() {
	/*char message[] = "Hello World!";
	SaySomething(message);*/

	if (false) {
		char symbol = '@';

		char* symbolPtr = &symbol;

		symbol = '$';

		cout << *symbolPtr << endl;
	}

	if (false) {
		char symbol = '%';

		char temp = symbol;

		temp = '$';

		cout << symbol << endl;
	}

	if (false) {
		int nums[] = { 1,2,3,4,5 };
		ChangeArray(nums);

		cout << nums[0] << endl;
	}

	if (false) {
		/*int number = 100;
		ChangeNumber(&number);
		cout << number << endl;*/

		int number = 100;
		int* numberPtr = &number;
		ChangeNumber(numberPtr);
		cout << number << endl;
	}

	if (false) {
		int number = 100;

		cout << number << endl;
		Decrement(&number);
		Increment(&number);
		Increment(&number);
		cout << number << endl;
	}

	if (false) {
		/*
		bool isAdult = false;
		isAdult = CheckAge(19);
		cout << isAdult << endl;
		*/

		bool isAdult = false;
		CheckAge(19, &isAdult);
		cout << isAdult << endl;
	}

	if (false) {
		/*int number = 123;
		int* numberPtr = &number;

		cout << *numberPtr << endl;*/

		/*
		double number = 1451.1313;		// 8 bytes
		int* numberPtr = (int*)&number;

		cout << *numberPtr << endl;
		*/
		
		/*
		short number = 123;
		int* numberPtr = (int*)&number;

		cout << *numberPtr << endl;
		*/

		/*
		int number = 123;
		number = 123123123;
		short* numberPtr = (short*)&number;

		cout << *numberPtr << endl;
		*/
	}
}