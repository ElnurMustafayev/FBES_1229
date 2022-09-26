#pragma once

#include "Employee.h"

struct Company {
	Employee* employees;
	int employeesCount = 0;

	char name[30]{};
	char desc[100]{};
};