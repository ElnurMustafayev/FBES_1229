#pragma once
#include <cstdlib>
#include <iostream>

using namespace std;

int* DeleteElement(int* nums, int* length) {
	if (*length == 0 || nums == nullptr)
		return nullptr;

	int* newArray = new int[*length - 1];

	// COPY OLD ELEMENTS
	for (int i = 0; i < (*length - 1); i++)
		newArray[i] = nums[i];

	(*length)--;

	return newArray;
}

int* AddElement(int* nums, int* length, int newElement) {
	int* newArray = new int[*length + 1]{};

	// COPY OLD ELEMENTS
	for (int i = 0; i < *length; i++)
		newArray[i] = nums[i];

	// DELETE OLD ARRAY
	delete[] nums;

	// ADD NEW ELEMENT TO END
	newArray[*length] = newElement;
	(*length)++;

	return newArray;

	/*nums[*lenght] = newElement;
	(*lenght)++;*/
}



void Print(int* arr, const int length) {
	for (int i = 0; i < length; i++)
		cout << arr[i] << endl;
}




int* CreateArray(int length) {
	srand(time(0));

	int* arr = new int[length];

	for (int i = 0; i < length; i++)
		arr[i] = rand();

	return arr;
}

