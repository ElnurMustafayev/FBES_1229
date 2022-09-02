#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <cstring>

#include "UserRegistration.h"

using namespace std;

//const int male = 0;
//const int female = 1;
//const int other = 2;

//enum GENDERS : int {
//	male = 0,
//	female = 1,
//	other,
//};

int main()
{
	/*const char* genderStr = "Male";
	genderStr = "Female";
	genderStr = "Other";*/


	//int genderNum = 0;		// male
	//genderNum = 1;			// female
	//genderNum = 2;			// other

	/*int genderNum = male;
	genderNum = female;
	genderNum = other;
	genderNum = 5;

	if (genderNum == other)
		cout << "WOOOOW" << endl;*/

	/*GENDERS gender1 = GENDERS::male;
	GENDERS gender2 = GENDERS::female;

	cout << (gender1 == GENDERS::other) << endl;
	cout << (gender1 == gender2) << endl;*/

	//GENDERS* genderPtr = new GENDERS(GENDERS::male);
	/*int num = 123;
	cout << &gender << endl << &num << endl;*/

	//cout << sizeof(GENDERS) << endl;


	/*GENDERS genders[3][2] {
		{GENDERS::male, GENDERS::male},
		{GENDERS::male, GENDERS::male},
		{GENDERS::male, GENDERS::male}
	};*/



	/*int genderInput;
	cin >> genderInput;

	GENDERS gender = (GENDERS)genderInput;

	cout << gender << endl;*/


	char* name = new char[100];
	char* surname = new char[100];
	GENDERS gender;

	Register(name, surname, &gender);
	cout << Validate(gender) << endl;
}