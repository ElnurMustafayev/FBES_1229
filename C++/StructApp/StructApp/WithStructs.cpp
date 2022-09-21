#include <iostream>

using namespace std;

const int randNamesCount = 5;

const char** names = new const char* [randNamesCount]{
	"One","Two","Three","Four","Five"
};

const char** surnames = new const char* [randNamesCount]{
	"One","Two","Three","Four","Five"
};


enum GENDERS : short {
	Male,
	Female,
	Other,
	Unknown,
};

struct MyStruct
{
	double salary;
	int num1;
	int num2;
};

struct Person {
	char* name;
	char* surname;
	short age;
	GENDERS gender;
};

void ShowPersonInfo(Person person) {
	/*srand(time(0));
	age = rand() % 100;*/
	
	cout << "name: " << (person.name == nullptr ? "Unknown" : person.name) << endl;
	cout << "surname: " << (person.surname == nullptr ? "Unknown" : person.surname) << endl;
	cout << "age: " << person.age << endl;
	cout << "gender: " << person.gender << endl;
}


void ClearPerson(Person person) {
	person.name = nullptr;
	person.surname = nullptr;
	person.age = -1;
	person.gender = GENDERS::Unknown;
}




Person GetRandomPerson() {
	srand(time(0));

	Person result = Person();
	
	result.name = (char*)names[(rand() % (randNamesCount - 1))];
	result.surname = (char*)surnames[(rand() % (randNamesCount - 1))];
	result.gender = (GENDERS)(rand() % 4);
	result.age = 10 + (rand() % 90);

	return result;
}



void main()
{
	//MyStruct obj = MyStruct();

	/*Person person = Person();

	person.name = (char*)"Bob";
	person.age = 32;
	person.gender = GENDERS::Unknown;*/

	/*Person person = Person();
	
	person.name = (char*)"Mike";
	person.age = new short(20);
	person.gender = GENDERS::Male;

	ClearPerson(person);
	ShowPersonInfo(person);*/

	ShowPersonInfo(GetRandomPerson());
}