#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <cstring>
#include <conio.h>
#include <windows.h>

using namespace std;

int len(char word[]);

char mytoupper(char symbol);
char mytolower(char symbol);

void ToUpperWord(char word[], int length);

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
		//// standart library
		//cout << (char)toupper('a') << endl;
		//cout << (char)toupper('A') << endl;
		//cout << (char)toupper('#') << endl;

		//cout << (char)tolower('a') << endl;
		//cout << (char)toupper('A') << endl;
		//cout << (char)toupper('#') << endl;

		//// custom
		//cout << mytoupper('a') << endl;		// A
		//cout << mytoupper('B') << endl;		// B
		//cout << mytoupper('@') << endl;		// 

		//cout << mytolower('a') << endl;		// a
		//cout << mytolower('B') << endl;		// b
		//cout << mytolower('@') << endl;		// 

		char word[10] = "Qwerty";
		ToUpperWord(word, 10);
		cout << word << endl;		// QWERTY

		// QWERTY	->   QWERTY
		// agd2#q	->   AGD2#Q
		// asc as	->   ASC AS
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

	if (true) {
		/*cout << "Home" << endl;
		cout << "About" << endl;
		cout << "Rating" << endl;
		cout << "Statistics" << endl;
		cout << "Exit" << endl;*/

		const int menuLength = 5;

		const int up = 72;
		const int down = 80;
		const int esc = 27;

		int cursor = 2;

		char menu[menuLength][20] = {
			"Home",
			"About",
			"Rating",
			"Statistics",
			"Exit"
		};

		while (true) {
			system("cls");
			PrintMenu(menu, menuLength, cursor);

			int key = _getch();
			
			if (key == esc) {
				system("cls");
				cout << "Bye!" << endl;
				break;
			}
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

void ToUpperWord(char word[], int length) {
	//for (int i = 0; i < length; i++)
	//{
	//	// lower
	//	if (word[i] >= 97 && word[i] <= 122)
	//		word[i] -= 32;
	//}

	for (int i = 0; i < length; i++)
		word[i] = toupper(word[i]);
}

char mytoupper(char symbol) {
	/*if (symbol == 'a')
		return 'A';
	if (symbol == 'b')
		return 'B';
	if (symbol == 'c')
		return 'C';*/

	const int registerDiff = 32;

	// upper
	if (symbol >= 65 && symbol <= 90)
		return symbol;

	// lower
	if (symbol >= 97 && symbol <= 122)
		return symbol - registerDiff;

	return ' ';
}

char mytolower(char symbol) {
	const int registerDiff = 32;

	// upper
	if (symbol >= 65 && symbol <= 90)
		return symbol + registerDiff;

	// lower
	if (symbol >= 97 && symbol <= 122)
		return symbol;

	return ' ';
}

void PrintMenu(char menu[5][20], int menuLength, int cursor) {
	// get console reference
	HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);

	for (int i = 0; i < menuLength; i++)
	{
		if (cursor == i) {
			SetConsoleTextAttribute(console, 0x70);
			//system("color 70");
			cout << (char)16 << " " << menu[i] << endl;
			//system("color 07");
			SetConsoleTextAttribute(console, 0x07);
		}
		else {
			cout << "  " << menu[i] << endl;
		}
	}
}

int len(char word[]) {
	for (int i = 0; ; i++)
		if (word[i] == '\0')
			return i;
}