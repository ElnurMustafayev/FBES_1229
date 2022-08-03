#pragma once
#include <iostream>
#include <cstring>

using namespace std;

int ConvertCharToInt(char numStr) {
	// [48,57]
	const int digitsIndex = 48;

	if ('0' <= numStr && numStr <= '9') {
		return (numStr - digitsIndex);
	}

	throw "Incorrect number format!";
}



int* Convert(char* numStr) {
	int size = strlen(numStr);

	int* nums = new int[size];

	for (int i = 0; numStr[i] != '\0'; i++)
	{
		try {
			nums[i] = ConvertCharToInt(numStr[i]);
		}
		catch (const char exceptionMsg[]) {
			delete[] nums;
			throw exceptionMsg;
		}
	}

	return nums;
}

void Print(int* numStr, int length) {
	for (int i = 0; i < length; i++)
	{
		cout << numStr[i] << endl;
	}
}