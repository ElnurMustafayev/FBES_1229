#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <cstdio>
#include <windows.h>

using namespace std;

const char* filename = "test.txt";

int main()
{
    FILE* file = fopen(filename, "r+");

    if (file == nullptr)
        cout << "File '" << filename << "' not found" << endl;
    else
        cout << "Stream address: " << file << endl;

    int symbol = 0;
    do {
        symbol = fgetc(file);
        Sleep(10);
        cout << (char)symbol;
    } while (symbol != -1);
}