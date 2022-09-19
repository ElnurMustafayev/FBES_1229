#pragma once

#include <iostream>

using namespace std;

enum GENDERS : short {
	Male,
	Female,
	Other,
	Unknown,
};

int peopleCount = 0;

char** names = new char* [peopleCount] {};
unsigned int* ages = new unsigned int[peopleCount] {};
GENDERS* genders = new GENDERS[peopleCount]{};


const char* ShowGender(GENDERS gender) {
	switch (gender) {
	case GENDERS::Male:
		return "Male";

	case GENDERS::Female:
		return "Female";

	case GENDERS::Other:
		return "Other";

	case GENDERS::Unknown:
	default:
		return "Unknown";
	}
}



// NAME
void AddName(const char* newName) {
	char** newNames = new char* [peopleCount + 1];

	// COPY old data
	for (int i = 0; i < peopleCount; i++)
	{
		newNames[i] = names[i];
	}

	newNames[peopleCount] = (char*)newName;

	names = newNames;
}



// AGE
void AddAge(unsigned int newAge) {
	unsigned int* newAges = new unsigned int[peopleCount + 1];

	// COPY old data
	for (int i = 0; i < peopleCount; i++)
	{
		newAges[i] = ages[i];
	}

	newAges[peopleCount] = newAge;

	ages = newAges;
}



// GENDER
void AddGender(GENDERS newGender) {
	GENDERS* newGenders= new GENDERS[peopleCount + 1];

	// COPY old data
	for (int i = 0; i < peopleCount; i++)
	{
		newGenders[i] = genders[i];
	}

	newGenders[peopleCount] = newGender;

	genders = newGenders;
}



void AddNewPerson(const char* newName, unsigned int newAge, GENDERS newGender) {
	AddName(newName);
	AddAge(newAge);
	AddGender(newGender);

	peopleCount++;
}



void GetPersonByIndex(unsigned int index) {
	if (index >= peopleCount)
		throw "index can not be bigger than list's count!";

	cout << "# " << index + 1 << endl;
	cout << "Name: " << names[index] << endl;
	cout << "Age: " << ages[index] << endl;
	cout << "Gender: " << ShowGender(genders[index]) << endl;

	cout << "\n\n";
}


void ShowPeople() {
	if(peopleCount == 0)
		throw "list of people is empty!";

	for (int i = 0; i < peopleCount; i++)
	{
		GetPersonByIndex(i);
	}
}