#pragma once

#include <iostream>
#include "Employee.h"

using namespace std;



Employee CreateNewEmployee() {
	Employee newEmployee = Employee();

	cout << "Name: ", cin >> newEmployee.name;
	cout << "Surame: ", cin >> newEmployee.surname;
	cout << "Age: ", cin >> newEmployee.age;
	cout << "IsMarried: ", cin >> newEmployee.isMarried;
	cout << "Salary: ", cin >> newEmployee.salary;

	return newEmployee;
}