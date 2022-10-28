#pragma once

#include <iostream>
#include <vector>

using namespace std;

template<typename T>
bool Contains(vector<T> arr, T elementToFind) {
	for (int i = 0; i < arr.size(); i++)
		if (arr[i] == elementToFind)
			return true;
	return false;
}

string months[] = {
	"January", 
	"February", 
	"March", 
	"April", 
	"May", 
	"June", 
	"July", 
	"August", 
	"September",
	"October", 
	"November", 
	"December"
};

class Person {
private:
	vector<int> monthsWith31 = { 1,3,5,7,8,10,12 };
	vector<int> monthsWith30 = { 4,6,9,11 };

	string name;

	int birthYear = -1;
	int birthMonth = -1;
	int birthDay = -1;

public:
	// ACCESSOR FOR YEAR
	int GetBirthYear() const {
		return this->birthYear;
	}
	void SetBirthYear(const int birthYear) {
		this->birthYear = birthYear;
	}

	// ACCESSOR FOR MONTH
	int GetBirthMonth() const {
		if (this->birthMonth == -1)
			throw "Birth Month not set!";

		return this->birthMonth;
	}
	void SetBirthMonth(const int birthMonth) {
		if (birthMonth <= 0 && birthMonth > 12)
			throw "Incorrect Birth Month!";

		this->birthMonth = birthMonth;
	}

	// ACCESSOR FOR DAY
	int GetBirthDay() const {
		if (this->birthDay == -1)
			throw "Birth Day not set!";

		return this->birthDay;
	}
	void SetBirthDay(const int birthDay) {
		if (birthMonth == -1)
			return;

		int birthMonth = GetBirthMonth();
		int monthLimitEnd = GetLimitForMonth(birthMonth);

		if (birthDay > 0 && birthDay <= monthLimitEnd) {
			this->birthDay = birthDay;
		}
		else
			throw "Incorrect Birth Day";
	}


	void SetBirthDate(int birthYear, int birthMonth, int birthDay) {
		SetBirthYear(birthYear);
		SetBirthMonth(birthMonth);
		SetBirthDay(birthDay);
	}
	void ShowBirthDate() {
		string month = months[this->GetBirthMonth() - 1];

		cout <<"BirthDay is: "  << this->GetBirthYear() << this->GetBirthDay() << ", " << month;
	}

	Person(string name)
	{
		this->name = name;
	}

	void ShowInfo() {
		cout << "Name: " << this->name << endl;
		try {
			ShowBirthDate();
		}
		catch(const char*) {}
	}

private:
	int GetLimitForMonth(int month) {
		if (Contains(this->monthsWith31, month))
			return 31;
		else if (Contains(this->monthsWith30, month))
			return 30;
		else if (month == 2)
			return 28;
		else {
			throw "Incorrect month!";
		}
	}
};