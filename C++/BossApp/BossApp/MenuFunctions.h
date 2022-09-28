#pragma once

#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <conio.h>
#include <windows.h>

#include "KeyboardKeys.h"

using namespace std;


const int menuLength = 4;
char** menu = new char* [menuLength] {
	(char*)"Add new Employee",
	(char*)"Show Employees",
	(char*)"Save",
	(char*)"Exit",
};



void PrintMenu(char** menu, int menuLength, int cursor) {
	// get console reference
	HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);

	for (int i = 0; i < menuLength; i++)
	{
		if (cursor == i) {
			SetConsoleTextAttribute(console, 0x70);
			cout << (char)16 << " " << menu[i] << endl;
			SetConsoleTextAttribute(console, 0x07);
		}
		else {
			cout << "  " << menu[i] << endl;
		}
	}
}


void Goodbye() {
	system("cls");
	cout << "Goodbye User" << endl;
}