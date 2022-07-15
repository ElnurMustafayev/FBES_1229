#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <cstring>
#include <conio.h>

using namespace std;

int len(char word[]);
void PrintMenu(char menu[5][20], int menuLength, int cursor);

int main()
{
	if (false) {
		char word[50] = "qwerty";
		char word2[50] = "test";

		//word = "Elnur";
		strcpy(word, "test");
		strcpy(word, word2);

		cout << word << endl;
	}

	if (false) {
		char word[50] = "qwerty";
		//char word[3] = { 'q', 'w', 'e' };
		
		//cout << "Word's length is: " << len(word) << endl;
		cout << "Word's length is: " << strlen(word) << endl;
	}

	if (false) {
		/*
		int age;
		cin >> age;
		cout << "Your age is: " << age << " years old";
		*/

		char word[80];
		cin >> word;
		cout << word << endl;
	}

	if (false) {
		//int key = cin.get();
		//int key = getchar();
		//cout << "Key: " << key << endl;

		/*char key;
		cin >> key;
		cout << "Key: " << (int)key << endl;*/
	}

	if (false) {
		const double pi = 3.14;

		cout << pi;
	}

	if (false) {
		system("dir");
	}

	if (false) {
		/*cout << "Home" << endl;
		cout << "About" << endl;
		cout << "Rating" << endl;
		cout << "Statistics" << endl;
		cout << "Exit" << endl;*/

		const int menuLength = 5;

		const int up = 72;
		const int down = 80;

		int cursor = 2;

		char menu[menuLength][20] = {
			"Home",
			"About",
			"Rating",
			"Statistics",
			"Exit"
		};

		while(true) {
			system("cls");
			PrintMenu(menu, menuLength, cursor);

			int key = _getch();

			if (key == down) {
				if (cursor == menuLength - 1)
					cursor = 0;
				else
					cursor++;
			}
			else if (key == up) {
				if (cursor == 0)
					cursor = menuLength - 1;
				else
					cursor--;
			}
		}
	}
}

void PrintMenu(char menu[5][20], int menuLength, int cursor) {
	for (int i = 0; i < menuLength; i++)
	{
		cout << (cursor == i) << menu[i] << endl;
	}
}

int len(char word[]) {
	for (int i = 0; ; i++)
		if (word[i] == '\0')
			return i;
}