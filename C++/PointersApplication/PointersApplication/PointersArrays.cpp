#include <iostream>
#include <cstdlib>

using namespace std;


int* SetRandomNumbers(int* nums, const int length) {
	for (int i = 0; i < length; i++) {
		*(nums + i) = rand();
		nums[i] = rand();
	}

	return nums;
}

int* GetZeroedArray(int nums[], const int length) {
	for (int i = 0; i < length; i++)
		nums[i] = 123;

	return nums;
}

void PrintArray(int* nums, const int length) {
	for (int i = 0; i < length; i++)
		cout << nums[i] << endl;

	cout << "\n\n\n";
}

int main() {
	/*const int length = 6;
	int nums[length] = { 436,54745,34523,523523,5,11 };

	PrintArray(nums, length);
	
	
	int* result = GetZeroedArray(nums, length);
	result = SetRandomNumbers(result, length);

	cout << result[0] << endl;
	cout << result[1] << endl;
	cout << result[2] << endl;
	
	
	PrintArray(nums, length);*/

	//srand(time(0));

	/*
	srand(time(0));
	cout << rand() % 100 << endl;
	cout << rand() % 100 << endl;
	cout << rand() % 100 << endl;
	cout << rand() % 100 << endl;
	*/





















	//int num = 123;
	//int* num = &num;
	//cout << sizeof(long long) << endl;


	//cout << nums << endl;
	//cout << &nums[0] << endl;

	/*short nums[] = { 123,777,100,-111 };
	short* numsPtr = nums;*/

	//cout << numsPtr << endl;
	//cout << numsPtr + 1 << endl;

	/*cout << nums[0] << endl;
	cout << *(numsPtr + 0) << endl;

	cout << nums[1] << endl;
	cout << *(numsPtr + 1) << endl;

	cout << nums[2] << endl;
	cout << *(numsPtr + 2) << endl;

	cout << nums[3] << endl;
	cout << *(numsPtr + 3) << endl;*/

	//cout << (numsPtr + 3) - numsPtr << endl; // 3




	/*
	short nums[] = { 123,777,100,-111 };
	short* numsPtr = nums;

	for (int i = 0; i < 4; i++)
		cout << *(numsPtr + i) << endl;
	*/



	/*int num1 = 100;
	int num2 = 100;
	long long test = 0;

	int* num1Ptr = &num1;
	int* num2Ptr = &num2;

	cout << num2Ptr - num1Ptr << endl;*/

	// nums[x][y] => ((x * y_size) + y) * sizeof()
	//int nums[3][3] = {
	//	{1,2,3},
	//	{4,5,6},
	//	{7,8,9},
	//};
	//
	//int* numsPtr = nums[0];
	//cout << nums[2][1] << endl; // ((2 * 3) + 1) * 4
	//cout << *(numsPtr + 7) << endl;

	//cout << nums[1][2] << endl;
	//cout << *(numsPtr + 8) << endl;
	
	//cout << (&nums[2][2] - &nums[0][0]) * sizeof(int) << endl;


	/*int nums[] = { 1,2,3,4,5 };

	cout << nums[3] << endl;
	int* numsPtr = nums;
	cout << *(numsPtr + 3) << endl;*/

	/*
	* int nums[3][3] = {
		{1,2,3},
		{4,5,6},
		{7,8,9}
	};

	cout << nums[1][1] << endl;
	int* numsPtr = nums[0];
	cout << *(numsPtr + 4) << endl;
	*/
}