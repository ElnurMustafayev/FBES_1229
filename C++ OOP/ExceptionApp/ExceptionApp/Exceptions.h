#pragma once

#include <iostream>

using namespace std;

class Exception {
public:
	string message;

	Exception(string message = "")
	{
		this->message = message;
	}
};



class DivisionByZeroException : public Exception {
public:
	DivisionByZeroException(string message) : Exception(message) {}
};



class ArgumentException : public Exception {
public:
	string argumentName = "";

	ArgumentException(string message) : Exception(message) {}
	ArgumentException(string message, string argumentName) : argumentName(argumentName), Exception(message) {}

	void GetMessage() {
		cout << "Error: " << this->message << endl;

		if (this->argumentName != "") {
			cout << "Argument: " << this->argumentName << endl;
		}
	}
};



class ArgumentNullptrException : public ArgumentException {
public:
	ArgumentNullptrException(string message) : ArgumentException(message) {}
	ArgumentNullptrException(string message, string argumentName) : ArgumentException(message, argumentName) {}
};