#include <iostream>
#include "Person.h"

using namespace std;

int main()
{
	Person* p = new Person("Bob");

	try {
		p->SetBirthDate(1985, 5, 5);

		p->ShowInfo();
	}
	catch (const char* errorMessage) {
		cout << "Error: " << errorMessage << endl;
	}
}