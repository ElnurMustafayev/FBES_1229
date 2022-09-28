#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

#include "Employee.h"
#include "Company.h"
#include "CompanyFunctions.h"
#include "EmployeeFunctions.h"
#include "MenuFunctions.h"
#include "FileFunctions.h"

using namespace std;

Company myCompany = Company();

const char* companyFilepath = "Company.txt";
const char* employeesFilepath = "Employees.txt";

void main()
{
	int cursor = 0;

	/*myCompany = LoadData<Company>(companyFilepath, 1);
	myCompany.employees = LoadArray<Employee>(companyFilepath, myCompany.employeesCount);*/

	//FILE* stream = fopen("Employees.txt", "r+");

	//Employee* e = new Employee[2];

	///*strcpy(e[0].name, "One");
	//strcpy(e[0].surname, "One");
	//e[0].age = 1;

	//strcpy(e[1].name, "Two");
	//strcpy(e[1].surname, "Two");
	//e[1].age = 2;

	//fwrite(e, sizeof(Employee), 2, stream);*/

	//fread(e, sizeof(Employee), 2, stream);

	//cout << e[0].name << endl;
	//cout << e[0].surname << endl;
	//cout << e[0].age << endl;

	//cout << e[1].name << endl;
	//cout << e[1].surname << endl;
	//cout << e[1].age << endl;

	//return;

	myCompany = LoadData<Company>(companyFilepath, 1);
	myCompany.employees = LoadArray<Employee>(companyFilepath, myCompany.employeesCount);

	/*FILE* stream = fopen(employeesFilepath, "r+");

	if (stream == nullptr)
		throw "Stream is empty";

	Employee* result = new Employee[myCompany.employeesCount];
	fread(result, sizeof(Employee), myCompany.employeesCount, stream);

	myCompany.employees = result;*/

	//cout << myCompany.employees[1].surname << endl;

	return;

	while (true) {
		system("cls");
		PrintMenu(menu, menuLength, cursor);

		int key = _getch();
		switch (key)
		{
		// ENTER
		case KEYBOARD_KEYS::enter: {

			switch (cursor)
			{
			// Add
			case 0: {
				system("cls");
				Employee created = CreateNewEmployee();
				AddNewEmployee(myCompany, created);
				system("cls");
				cout << "User " << created.name << " added successfully!";
				_getch();
				break;
			}
			// Print All Employees
			case 1: {
				system("cls");
				PrintEmployees(myCompany.employees, myCompany.employeesCount);
				_getch();
				break;
			}
			// SAVE
			case 2: {
				Save(companyFilepath, &myCompany, 1);
				Save(employeesFilepath, myCompany.employees, myCompany.employeesCount);
				break;
			}
			// Exit
			case 3: {
				Goodbye();
				return;
			}
			}
			
			break;
		}

		// DOWN
		case KEYBOARD_KEYS::down: {
			if (cursor == menuLength - 1)
				cursor = 0;
			else
				cursor++;
			break;
		}

		// UP
		case KEYBOARD_KEYS::up: {
			if (cursor == 0)
				cursor = menuLength - 1;
			else
				cursor--;
			break;
		}

		// ESC
		case KEYBOARD_KEYS::esc: {
			Goodbye();
			return;
		}
		}
	}
}