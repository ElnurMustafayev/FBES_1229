#include <iostream>

#include "Employee.h"
#include "Company.h"
#include "CompanyFunctions.h"
#include "EmployeeFunctions.h"
#include "MenuFunctions.h"

using namespace std;

Company myCompany = Company();

int main()
{
	int cursor = 0;

	while (true) {
		system("cls");
		PrintMenu(menu, menuLength, cursor);

		int key = _getch();

		if (key == KEYBOARD_KEYS::enter) {
			Employee created = CreateNewEmployee();
			AddNewEmployee(myCompany, created);
		}
		else if (key == KEYBOARD_KEYS::down) {
			if (cursor == menuLength - 1)
				cursor = 0;
			else
				cursor++;
		}
		else if (key == KEYBOARD_KEYS::up) {
			if (cursor == 0)
				cursor = menuLength - 1;
			else
				cursor--;
		}
		else if (key == KEYBOARD_KEYS::esc) {
			system("cls");
			PrintEmployees(myCompany.employees, myCompany.employeesCount);
			break;
		}
	}


	/*char name[30]{};
	char surname[30]{};

	unsigned short age;
	GENDERS gender;
	double salary;
	bool IsMarried = false;*/

	//Employee newEmployee{
	//	"Bob",
	//	"Marley",
	//	52,
	//	GENDERS::Male,
	//	34234,
	//	false
	//};

	//AddNewEmployee(myCompany, newEmployee);
	//AddNewEmployee(myCompany, newEmployee);
	//AddNewEmployee(myCompany, newEmployee);

	////PrintEmployees(myCompany.employees, myCompany.employeesCount);
}