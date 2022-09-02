#pragma once

#include <iostream>

using namespace std;



enum GENDERS : int {
	male, 
	female
};



void Register(char* name, char* surname, GENDERS* gender) {
	cout << "Name: ";
	cin >> name;
	cout << "Surname: ";
	cin >> surname;

	int genderInput;
	cout << "0 - Male, 1 - Female: ";
	cin >> genderInput;

	*gender = (GENDERS)genderInput;
}

bool Validate(GENDERS gender) {
	bool isSuccess = gender == GENDERS::male || gender == GENDERS::female;

	cout << (isSuccess ? "OK" : "Error") << endl;
	return isSuccess;
}