#include <iostream>

using namespace std;

int ChangeNumber(int num);
void PrintArray(int nums[5], int length);
void ChangeArray(int nums[]);
int GetNullTerminatorIndex(char word[], int length);
void SwapElementsInArray(int arr[], int left, int right);

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

	if (true) {
		//int number = 100;
		//cout << ChangeNumber(number) << endl;
		//cout << number << endl;

		/*int nums[] = { 1,2,3,4,5 };

		ChangeArray(nums);

		PrintArray(nums, 5);*/

		// value types
		/*
			int num1 = 123;
			int num2 = num1;
			num2 += 100;

			cout << num1 << endl;	// 123
			cout << num2 << endl;	// 223
		*/

		// reference types
		/*
			int nums1[5] = { 1,2,3,4,5 };
			int* nums2 = nums1;
		
			nums2[2] = 123;

			PrintArray(nums1, 5);

			cout << endl;

			PrintArray(nums2, 5);
		*/
	}

	if (false) {
		// char arr[] = { true, 'q', 123, 453.6346 };

		char word[] = {'q','w', 'e', 'r', 't','y', '\0', '2', '\n', '\a', 123, '\0'};

		cout << word << endl;
		cout << word[2] << endl;
	}

	if (false) {
		char word[] = {1,2,3,4,5};

		cin >> word;

		for (int i = 0; i < 10; i++)
		{
			cout << word[i] << endl;
		}

		//cout << "Word: " << word << endl;
	}

	if (false) {
		char word[100] = {};

		cin >> word;

		cout << "Index of '\\0': " << GetNullTerminatorIndex(word, 100) << endl;;
	}

	if (false) {
		int nums[] = { 1,2,3,4,5 };

		PrintArray(nums, 5);
		cout << endl;

		int temp = nums[1];
		nums[1] = nums[4];
		nums[4] = temp;

		PrintArray(nums, 5);
	}

	if (true) {
		int nums[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		int left, right;

		cout << "Input indexes to swap: " << endl, cin >> left, cin >> right;

		SwapElementsInArray(nums, left, right);

		PrintArray(nums, 10);
	}
}

void SwapElementsInArray(int arr[], int left, int right) {
	int temp = arr[left];
	arr[left] = arr[right];
	arr[right] = temp;
}

int GetNullTerminatorIndex(char word[], int length) {
	for (int i = 0; i < length; i++)
		if (word[i] == '\0') 
			return i;
}

void ChangeArray(int nums[]) {
	nums[2] = -123;
}

int ChangeNumber(int number) {
	number = 123;

	cout << number << endl;

	return number;
}

void PrintArray(int nums[], int length) {
	for (int i = 0; i < length; i++) {
		cout << "nums[" << i << "] = \t" << nums[i] << endl;
	}
}