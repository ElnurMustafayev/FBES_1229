#include <iostream>
#include "ArrayFunctions.h"

using namespace std;

int main()
{
	/*
		int arr1[10] = { 1,2,3 };
		cout << arr1[8] << endl;
		int* arr1Ptr = arr1;
	*/

	/*
		int* arr2 = new int[];
		cout << arr2 << endl;
		cout << &(arr2[0]) << endl;
	*/



	// int* arr = CreateArray(10);
	// Print(arr, 10);

	/*
	int length = 10;
	int* arr = CreateArray(length);
	AddElement(arr, 123);
	arr[11] = 234;
	arr[12] = 345;
	Print(arr, length);
	cout << arr[10] << endl;
	cout << arr[11] << endl;
	cout << arr[12] << endl;
	*/



	/*int num1 = 10;
	int num2 = 15;

	int* num1Ptr = &num1;
	int* num2Ptr = &num2;

	int steps = num2Ptr - num1Ptr;
	*(num1Ptr + steps) = 777;

	cout << num2 << endl;*/



	/*int length = 3;
	int* arr = new int[length] {
		1, 2, 3
	};

	int nums[10];

	int number = 1;
	cout << (nums - &number) << endl;

	AddElement(arr, &length, 4);
	AddElement(arr, &length, 5);
	AddElement(arr, &length, 6);
	AddElement(arr, &length, 7);
	AddElement(arr, &length, 8);
	Print(arr, length);

	cout << "Number: " << number << endl;*/




	/*int number = 2147483647;
	int* numberPtr = &number;

	bool* byteptr = (bool*)numberPtr;

	cout << *(byteptr + 0) << endl;
	cout << *(byteptr + 1) << endl;
	cout << *(byteptr + 2) << endl;
	cout << *(byteptr + 3) << endl;*/





	/*
	int length = 3;
	int* arr = new int[length] {
		1, 2, 3
	};

	for (int i = 0; i < 100; i++)
		arr = AddElement(arr, &length, i);

	Print(arr, length);
	*/



	/*int length = 5;
	int* arr = new int[length] {
		1, 2, 3, 4, 5
	};*/

	/*arr = DeleteElement(arr, &length);
	cout << arr << endl;
	arr = DeleteElement(arr, &length);
	cout << arr << endl;
	arr = DeleteElement(arr, &length);
	cout << arr << endl;
	arr = DeleteElement(arr, &length);
	cout << arr << endl;
	arr = DeleteElement(arr, &length);
	cout << arr << endl;
	arr = DeleteElement(arr, &length);
	cout << arr << endl;
	arr = DeleteElement(arr, &length);
	cout << arr << endl;
	arr = DeleteElement(arr, &length);
	cout << arr << endl;
	arr = DeleteElement(arr, &length);
	cout << arr << endl;
	arr = DeleteElement(arr, &length);
	cout << arr << endl;
	Print(arr, length);*/



	//arr = DeleteElement(nullptr, &length);



	/*int* numPtr = new int(10);
	cout << numPtr << endl;
	numPtr = 0;
	numPtr = nullptr;
	cout << numPtr << endl;*/

	/*int length = 1000;
	int* arr = new int[length]{};

	for (int i = 0; i < 100000; i++)
	{
		if (i % 10000 == 0) {
			cin.ignore();
			cin.get();
		}

		arr = AddElement(arr, &length, i);
	}*/


	/*int* nums1 = new int[10000000];
	int* nums2 = new int[10000000];
	int* nums3 = new int[10000000];
	int* nums4 = new int[10000000];
	int* nums5 = new int[10000000];

	delete[] nums1;
	delete[] nums2;
	delete[] nums3;
	delete[] nums4;
	delete[] nums5;*/

	/*{
		int stackArray[10000];
		int* nums5 = stackArray;
		delete[] nums5;
	}
	cout << "end of local" << endl;
	cin.get();*/

	/*int nums[10];
	delete[] nums;*/


	
	//int* nums = new int[100000];

	//delete nums;


	//int num = 100;
	//int* numm = new int(100);
	//delete numm;

	//cout << *numm << endl;
	////numm = nullptr;

	//if (numm != nullptr) {}
	////cout << numm << endl;
	////cout << numm - &num << endl;
}