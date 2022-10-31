#pragma once

#include <iostream>
#include <vector>

#include "Functions.h"
#include "Exception.h"

using namespace std;

vector<int> monthsWith31 = { 1,3,5,7,8,10,12 };
vector<int> monthsWith30 = { 4,6,9,11 };

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


class DateTime {
	int year = -1;
	int month = -1;
	int day = -1;

public:
	DateTime(int year, int month, int day) {
		SetYear(year);
		SetMonth(month);
		SetDay(day);
	}

	DateTime() {

	}

	void ShowDate() {
		string month = months[this->GetMonth() - 1];

		cout << this->GetYear() << " " << this->GetDay() << ", " << month << endl;
	}

	// ACCESSOR FOR YEAR
	int GetYear() const {
		return this->year;
	}
	void SetYear(const int year) {
		this->year = year;
	}

	// ACCESSOR FOR MONTH
	int GetMonth() const {
		if (this->month == -1)
			throw Exception("Month not set!", 235);

		return this->month;
	}
	void SetMonth(const int month) {
		if (month <= 0 && month > 12)
			throw Exception("Incorrect Month!", 565);

		this->month = month;
	}

	// ACCESSOR FOR DAY
	int GetDay() const {
		if (this->day == -1)
			throw Exception("Day not set!", 789);

		return this->day;
	}
	void SetDay(const int day) {
		if (month == -1)
			return;

		int month = GetMonth();
		int monthLimitEnd = GetLimitForMonth(month);

		if (day > 0 && day <= monthLimitEnd) {
			this->day = day;
		}
		else
			throw Exception("Incorrect Day", 235);
	}

	static DateTime Now() {
		long long t = time(0);
		tm* now = localtime(&t);

		now->tm_year += 1900;

		DateTime current = DateTime(now->tm_year, now->tm_mon + 1, now->tm_mday);

		return current;
	}


private:
	int GetLimitForMonth(int month) {
		if (Contains(monthsWith31, month))
			return 31;
		else if (Contains(monthsWith30, month))
			return 30;
		else if (month == 2)
			return 28;
		else {
			throw Exception("Incorrect Month", 345);
		}
	}
};