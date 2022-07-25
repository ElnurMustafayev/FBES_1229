#include <iostream>
#include "Functions.h"

using namespace std;

int GetMin(int nums[], const int lenght) {
	if (lenght <= 0)
		return 0;

	int min = nums[0];

	for (int i = 0; i < lenght; i++)
	{
		if (nums[i] < min)
			min = nums[i];
	}

	return min;
}



int GetUppersCount(char symbol1, char symbol2, char symbol3, char symbol4) {
	int count = 0;

	char symbols[] = {
		symbol1,
		symbol2,
		symbol3,
		symbol4,
		'\0'
	};

	for (int i = 0; symbols[i] != '\0'; i++)
		count += ('A' >= symbols[i] && symbols[i] >= 'Z');

	return count;



	return ('A' >= symbol1 && symbol1 >= 'Z')
		+ ('A' >= symbol2 && symbol2 >= 'Z')
		+ ('A' >= symbol3 && symbol3 >= 'Z')
		+ ('A' >= symbol4 && symbol4 >= 'Z');
}


int MMain() {
	int nums[] = {5555,12345314,453453343,1243453452,41241};
	GetMin(nums, 5);

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

	return 0;
}