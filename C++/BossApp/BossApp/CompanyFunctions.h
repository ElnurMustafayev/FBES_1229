#pragma once

#include <iostream>

#include "Employee.h"
#include "Company.h"

using namespace std;

void AddNewEmployee(Company& company, Employee newEmployee) {
	Employee* newEmployees = new Employee[company.employeesCount + 1];

	for (int i = 0; i < company.employeesCount; i++)
		newEmployees[i] = company.employees[i];

	company.employees = newEmployees;
	company.employees[company.employeesCount] = newEmployee;

	company.employeesCount++;
}



void PrintEmployees(Employee* employees, int count) {
	for (int i = 0; i < count; i++) {
		cout << employees[i].name << endl;
		cout << employees[i].surname << endl;
		cout << employees[i].age << endl;
		cout << employees[i].gender << endl;
		cout << employees[i].isMarried << endl;
		cout << employees[i].salary << endl << endl;
	}
}