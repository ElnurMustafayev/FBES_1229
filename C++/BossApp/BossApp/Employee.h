#pragma once

#include "Genders.h"

struct Employee {
	char name[30]{};
	char surname[30]{};

	unsigned short age;
	GENDERS gender;
	double salary;
	bool isMarried = false;
};