#pragma once

#include <iostream>

using namespace std;


class String {

public:
	char text[1000];

	String(char* text)
	{
		strcpy(this->text, text);
	}

	String(const char* text)
	{
		strcpy(this->text, text);
	}

	void operator += (char* text) {
		strcat(this->text, text);
	}

	void operator += (const char* text) {
		strcat(this->text, text);
	}

	void operator += (String str) {
		strcat(this->text, str.text);
	}
};


class Number {
public:
	int value;

	Number() : value(0) {}
	Number(int value) : value(value) {}

	void operator +(Number& num) {
		cout << this << endl;
		num + *this;
	}
	int operator +(int otherNumber) {
		return this->value + otherNumber;
	}
	void operator += (int otherNumber) {
		this->value += otherNumber;
	}
	int operator -(int otherNumber) {
		return this->value - otherNumber;
	}
	int operator -=(int otherNumber) {
		return this->value -= otherNumber;
	}
	double operator / (int number) {
		if (number == 0)
			throw "divider can not be 0!";

		return number / this->value;
	}






	bool operator >(string word) {
		return this->value > word.length();
	}

	double operator <(double value) {
		return this->value - value;
	}

	template<typename T>
	bool operator != (T number) {
		return number == this->value;
	}

	bool operator == (Number& otherNumber) {
		//if (otherNumber.value == this->value)
		//cout << this << " == "  << &otherNumber << endl;

		/*if (this == &otherNumber)
			return true;
		else
			return false;*/

		return (this == &otherNumber);
	}

	template<typename T>
	bool operator == (T) {
		return sizeof(*this) == sizeof(T);
	}


	int operator ++ () {
		return ++this->value;
	}

	int operator ++ (int) {
		return this->value++;
	}


	void operator ^(int) {
		cout << "Test";
	}
};