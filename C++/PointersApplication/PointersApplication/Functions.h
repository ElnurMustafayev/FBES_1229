#pragma once

#include<iostream>

using namespace std;

void SaySomething(char message[]) {
	cout << message << endl;
}

void ChangeArray(int nums[]) {
	nums[0] = 123;
}

void ChangeNumber(int number) {
	number = 700;
}

void ChangeNumber(int* number) {
	*number = 700;
}

int Decrement(int* number) {
	//*number = (*number - 1);
	//*number -= 1;
	return --(*number);
}

int Increment(int* number) {
	//*number = (*number - 1);
	//*number -= 1;
	return ++(*number);
}

bool CheckAge(int age) {
	return age >= 18;
}

void CheckAge(int age, bool* isAdult) {
	*isAdult = age >= 18;
}