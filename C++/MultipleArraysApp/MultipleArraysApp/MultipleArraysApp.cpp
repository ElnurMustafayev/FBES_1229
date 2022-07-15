#include <iostream>

using namespace std;

int GetElementIndex(int nums[], int element, int length);
int GetElementByIndex(int nums[], int length, int index);
void PrintArray(int nums[], int length);
void PrintDoubleArray(int nums[][3], int rowsCount);

int main()
{
	if (false) {
		int nums[] = { 1,2,3,4,5,6,7,8,9 };
		int length = 9;

		cout << GetElementIndex(nums, 15, length);
	}

	if (false) {
		int nums[] = { 1,2,3,4,5 };
		int length = 5;

		cout << GetElementByIndex(nums, length, 15);
	}

	if (false) {
		/*char word[] = "qwerty";
		cout << word[5] << endl;*/

		/*int nums[2][4] = {
			{1,2,3,4},
			{5,6,7,8},
		};*/

		int nums[][3] = {
			{4,5,6},
			{8,2,6},
			{3,4,5},
			{3,10,5},
			{8,2,6},
		};

		cout << nums[3][1] + nums[1][2] << endl;

		PrintDoubleArray(nums, 8);
	}

	if (false) {
		char names[][6] = {
			{'d', 'a', 'n', 'i', 'z', '\0'},
			{'r', 'u', 'f', 'a', 't', '\0'},
			{'e', 'l', 'n', 'u', 'r', '\0'},
		};

		for (int i = 0; i < 3; i++)
		{
			cout << names[i] << endl;
		}
	}

	if (false) {
		char names[][6] = {
			{'d', 'a', 'n', 'i', 'z', '\0'},
			{'r', 'u', 'f', 'a', 't', '\0'},
			{'e', 'l', 'n', 'u', 'r', '\0'},
		};

		for (int i = 0; i < 3; i++)
		{
			cout << names[i] << endl;
		}
	}

	if (true) {
		int arr[2][3][3] = {
			{
				{1,2,3},
				{1,2,3},
				{1,2,3}
			},
			{
				{1,2,3},
				{1,2,3},
				{1,2,3}
			}
		};

		cout << arr[1][1][1] << endl;
	}
}

void PrintDoubleArray(int nums[][3], int rowsCount) {
	for (int x = 0; x < rowsCount; x++)
	{
		for (int y = 0; y < 3; y++)
		{
			cout << nums[x][y] << "\t";
		}
		cout << endl;
	}
}

int GetElementByIndex(int nums[], int length, int index) {
	return (index >= 0 && index < length)
		? nums[index]
		: -1;
}

int GetElementIndex(int nums[], int element, int length) {
	for (int i = 0; i < length; i++)
		if (nums[i] == element)
			return i;

	return -1;
}

void PrintArray(int nums[], int length) {
	for (int i = 0; i < length; i++) {
		cout << "nums[" << i << "] = \t" << nums[i] << endl;
	}
}