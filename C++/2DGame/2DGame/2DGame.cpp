#include "Logic.h"

int main()
{
	int** area = new int* [8]{
		new int[14] {},
		new int[14] {},
		new int[14] {},
		new int[14] {},
		new int[14] {},
		new int[14] {},
		new int[14] {},
		new int[14] {}
	};

	InitBorder(area);
	area[heroY][heroX] = 1;

	while (true) {
		Print(area);

		int inputKey = Input();

		bool toExit = Logic(area, inputKey);

		if(toExit)
			break;
	}

	system("cls");
	cout << "Goodbye!" << endl;
}