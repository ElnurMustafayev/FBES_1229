#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <cstdio>
#include <windows.h>

using namespace std;

const char* filename = "test.txt";

void PrintAllTest(FILE* file, int ms);

int GetLettersCountInFile(FILE* file);

void WriteInFile(FILE* file, const char* word);



void main()
{
    /*FILE* file = fopen("C:\\Users\\e.mustafayev\\Desktop\\Code\\FBES_1229\\C++\\FileSystemApp\\FileSystemApp\\test.txt", "r+");
    FILE* file = fopen("Test\\test.txt", "r+");*/

    FILE* file = fopen(filename, "r+");

    if (file == nullptr) {
        cout << "File '" << filename << "' not found" << endl;
        return;
    }

    //PrintAllTest(file, 50);
    //cout << GetLettersCountInFile(file);

    WriteInFile(file, "Elnur");
}


int GetLettersCountInFile(FILE* file) {
    /*int counter = 0;
    while (!feof(file)) {
        counter++;

        cout << (char)fgetc(file) << " " << counter << endl;
    }

    return counter - 1;*/

    int counter = 0;
    char symbol = ' ';
    while ((symbol = fgetc(file)) != EOF) {
        counter++;
    }

    return counter;
}

void PrintAllTest(FILE* file, int ms = 10) {
    int symbol = 0;
    do {
        symbol = fgetc(file);
        Sleep(ms);
        cout << (char)symbol;
    } while (symbol != -1);
}

void WriteInFile(FILE* file, const char* word) {
    for (int i = 0; word[i] != '\0'; i++)
        fputc(word[i], file);
}