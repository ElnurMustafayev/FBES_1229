#include <iostream>

using namespace std;

int ChangeNumber(int num);
void PrintArray(int nums[5], int length);

int main()
{
	if(false) {
		int nums[4];

		// -858993460
		cout << nums[3] << endl;
	}

	if(false) {
		double nums[5] = {};

		// default value
		cout << nums[2] << endl;
	}

	if (false) {
		/* Bad solution
		int nums[5] = {};
		
		nums[0] = 1;
		nums[1] = 2;
		nums[2] = 3;
		nums[3] = 4;
		nums[4] = 5;

		cout << nums[0] << endl;
		cout << nums[1] << endl;
		cout << nums[2] << endl;
		cout << nums[3] << endl;
		cout << nums[4] << endl;
		*/

		// good solution 
		int nums[5] = {};

		// set values
		for (int i = 0, value = 1; i < 5; i++, value++) {
			nums[i] = value;
		}

		// print
		for (int i = 0; i < 5; i++) {
			cout << "nums[" << i << "] = \t" << nums[i] << endl;
		}
	}

	if (false) {
		int number = 100;

		cout << ChangeNumber(number) << endl;

		cout << number << endl;
	}

	if (false) {
		{
			int nums[] = { 234, -12, 10, 0, 324 };

			PrintArray(nums, 5);
		}

		cout << endl;
		
		{
			int nums[3] = { 234, -12, 10 };

			PrintArray(nums, 3);
		}
	}
}

void PrintArray(int nums[], int length) {
	for (int i = 0; i < length; i++) {
		cout << "nums[" << i << "] = \t" << nums[i] << endl;
	}
}

int ChangeNumber(int num) {
	num = 123;

	cout << num << endl;

	return num;
}