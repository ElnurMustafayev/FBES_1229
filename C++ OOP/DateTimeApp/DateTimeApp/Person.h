#pragma once


#include <iostream>
#include <vector>

#include "DateTime.h"
#include "Exception.h"

using namespace std;

class Person {
private:
	string name;
	DateTime* birthDate = nullptr;

public:
	Person(string name, DateTime* birthDate = nullptr)
	{
		this->name = name;
		this->birthDate = birthDate;
	}

	Person()
	{
	}

	void ShowInfo() {
		cout << "Name: " << this->name << endl;

		if (this->birthDate != nullptr) {
			cout << this->name << "'s Bday: ";
			this->birthDate->ShowDate();
		}
	}

	int GetAge() {
		if (this->birthDate == nullptr)
			throw Exception("birthDate not set!", 777, false);

		DateTime now = DateTime::Now();

		return (now.GetYear() - this->birthDate->GetYear());
	}
};