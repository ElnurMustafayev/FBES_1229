#pragma once

#include <cstdio>
#include <cstring>

#include "Employee.h"



template<typename TData>
void Save(const char* filepath, TData* data, int count) {
	FILE* stream = fopen(filepath, "r+");

	if (stream == nullptr)
		throw "Stream is empty";

	fwrite(data, sizeof(TData), count, stream);
}



template<typename TData>
TData LoadData(const char* filepath, int count) {
	FILE* stream = fopen(filepath, "r+");

	if (stream == nullptr)
		throw "Stream is empty";

	TData data;
	fread(&data, sizeof(TData), count, stream);

	return data;
}



template<typename TData>
TData* LoadArray(const char* filepath, const int count) {
	FILE* stream = fopen(filepath, "r+");

	if (stream == nullptr)
		throw "Stream is empty";

	Employee* result = new Employee[count];
	fread(result, sizeof(Employee), count, stream);

	cout << result[0].name << endl;

	
	return result;
}