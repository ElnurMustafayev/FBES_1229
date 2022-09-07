#pragma once

#include <iostream>
#include <conio.h>

using namespace std;


enum KEYBOARD_KEYS {
	up = 72,
	down = 80, 
	left = 75, 
	rigth = 77,
	enter = 13,
};

const int horizontalLength = 14;
const int verticalLength = 8;

int heroX = 3;
int heroY = 4;

void InitBorder(int** area) {
	for (int y = 0; y < verticalLength; y++)
	{
		for (int x = 0; x < horizontalLength; x++)
		{
			if(y == 0 || y == verticalLength - 1)
				area[y][x] = 2;

			if(x == 0 || x == horizontalLength - 1)
				area[y][x] = 2;
		}
	}

	area[5][5] = 2;
	area[5][6] = 2;
	area[5][7] = 2;
	area[5][8] = 2;
}

void Print(int** area) {
	system("cls");
	
	for (int y = 0; y < verticalLength; y++)
	{
		for (int x = 0; x < horizontalLength; x++)
		{
			switch (area[y][x])
			{
			case 0:
				cout << " ";
				break;
			case 1:
				cout << (char)1;
				break;
			case 2:
				cout << (char)254;
				break;
			}
		}
		cout << endl;
	}
}

int Input() {
	return _getch();
}

bool Logic(int** area, int inputKey) {
	switch (inputKey) {
	case KEYBOARD_KEYS::up:
		if(heroY > 0 && area[heroY - 1][heroX] != 2)
			area[heroY--][heroX] = 0;
		break;
	case KEYBOARD_KEYS::down:
		if (heroY < verticalLength - 1 && area[heroY + 1][heroX] != 2)
			area[heroY++][heroX] = 0;
		break;
	case KEYBOARD_KEYS::left:
		if(heroX > 0 && area[heroY][heroX - 1] != 2)
			area[heroY][heroX--] = 0;
		break;
	case KEYBOARD_KEYS::rigth:
		if (heroX < horizontalLength - 1 && area[heroY][heroX + 1] != 2)
			area[heroY][heroX++] = 0;
		break;
	case KEYBOARD_KEYS::enter:
		return true;
	}

	area[heroY][heroX] = 1;

	return false;
}