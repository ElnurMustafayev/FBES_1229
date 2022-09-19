#define _CRT_SECURE_NO_WARNINGS
#include <cstdio>
#include "FunctionsForArrays.h"

int main()
{
	AddNewPerson("Ann", 15, GENDERS::Female);
	AddNewPerson("Bob", 7, GENDERS::Other);
	AddNewPerson("Mike", 35, GENDERS::Male);

	try {
		ShowPeople();

		GetPersonByIndex(5);
	}
	catch (const char* message) {
		cout << "Error: " << message << endl;
	}
}