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

class IndexOutOfRangeException : public Exception {
protected:
	int index;
public: 

	IndexOutOfRangeException(int index, string message = "") : Exception(message)
	{
		this->index = index;
	}

	void Show() {
		cout << "Error: " << this->message << endl;
		cout << "Index: " << this->index << endl;
	}
};