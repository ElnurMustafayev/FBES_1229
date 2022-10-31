#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include "Person.h"
#include "Exception.h"

using namespace std;

int Div(int num1, int num2) {
	if (num2 == 0) {
		throw new Exception("Divider can not be 0!");
	}

	return num1 / num2;
}

int main()
{
	try {
		Div(10, 0);
	}
	catch (Exception ex) {
		ex.ShowError();
	}
	catch (Exception* ex) {
		ex->ShowError();
	}



	
	/*
		DateTime birthDay = DateTime(1982, 5, 5);
		Person* p = new Person("Bob", &birthDay);
		Person* p1 = new Person();

		try {
			p1->ShowInfo();

			cout << p1->GetAge() << endl;
		}
		catch (Exception ex) {
			cout << "Message: " << ex.Message << endl;
			cout << "Code: " << ex.Code << endl;
			cout << "Success: " << ex.Success << endl;
		}
	*/
}