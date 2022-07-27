#include <iostream>

using namespace std;

int* CreateArray(const int length);

int main()
{
	//int nums[10];

	/*int length = 10;
	int* nums = new int[length] {
		1, 2, 3, 4, 5, 6, 7, 8, 9, 0
	};*/

	//cout << nums[5] << endl;
	//cout << *(nums + 1) << endl;

	/*int num = 100;
	cout << num << endl;*/

	/*int num = 10;
	int* numPtr = &num;

	cout << numPtr << endl;
	cout << sizeof(numPtr) << endl;*/

	/*int length = 10;
	int* newArr = CreateArray(length);
	Print(newArr, length);*/


	char* word = new char[100]{ "test" };

	cout << word << endl;
}

int* CreateArray(const int length) {
	//int arr[length];

	int* arr = new int[length];

	for (int i = 0; i < length; i++)
		arr[i] = i;

	return arr;
}

void Print(int* arr, const int length) {
	for (int i = 0; i < length; i++)
		cout << arr[i] << endl;
}