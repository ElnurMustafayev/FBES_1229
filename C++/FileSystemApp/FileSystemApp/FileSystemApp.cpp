#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <cstdio>
#include <cstring>
#include <windows.h>

using namespace std;

const char* filename = "test.txt";

void PrintAllTest(FILE* file, int ms);

int GetLettersCountInFile(FILE* file);

void WriteInFile(FILE* file, const char* word);

void CreateMyFile(const char* newFilename, const char* fileExtension);




void main()
{
    /*FILE* file = fopen("C:\\Users\\e.mustafayev\\Desktop\\Code\\FBES_1229\\C++\\FileSystemApp\\FileSystemApp\\test.txt", "r+");
    FILE* file = fopen("Test\\test.txt", "r+");*/

    /*FILE* file = fopen(filename, "r+");

    if (file == nullptr) {
        cout << "File '" << filename << "' not found" << endl;
        return;
    }

    fclose(file);

    remove(filename);*/

    //PrintAllTest(file, 50);
    //cout << GetLettersCountInFile(file);

    //WriteInFile(file, "Elnur");

    /*cout << fgetc(file) << endl;
    cout << fputc('A', file) << endl;*/

    /*CreateMyFile(new char[] { "one" }, ".txt");
    CreateMyFile(new char[] { "two" }, "txt");*/

    /*for (int i = 65; i < 68; i++)
    {
        char* filename = new char[] {
            (char)i, '\0'
        };
        
        CreateMyFile(filename, ".txt");
        CreateMyFile(filename, "txt");
    }*/

    /*int nums[]{
        1,2,3,4,5,6
    };

    int* numsPtr = nums;

    cout << sizeof numsPtr << endl;*/

    //WRITE
    if(false) {
        srand(time(0));

        int length = 5;

        int* arr = new int[length] {
            rand(),
            rand(),
            rand(),
            rand(),
            rand(),
        };

        for (int i = 0; i < length; i++)
        {
            cout << arr[i] << endl;
        }

        FILE* file = fopen(filename, "w");

        cout << fwrite(arr, sizeof(arr[0]) * length, 1, file);
    }
    
    // READ
    if(false) {
        int length = 10;
        int* buffer = new int[length] {};

        FILE* file = fopen(filename, "r+");
        cout << fread(buffer, sizeof(buffer[0]), length, file) << endl;

        for (int i = 0; i < length; i++)
        {
            cout << buffer[i] << endl;
        }
    }
    


    FILE* stream = fopen("test.txt", "r+");
    bool isEmpty = (fgetc(stream) == -1);

    char name[20];

    if (isEmpty) {
        cin >> name;

        fwrite(name, sizeof(name), 1, stream);
    }
    else {
        fseek(stream, -18, SEEK_END);

        fread(name, sizeof(name), 1, stream);

        cout << name << endl;
    }
}

void CreateMyFile(const char* newFilename, const char* fileExtension) {
    if (fileExtension == nullptr)
        throw "extension con not be empty!";

    if (fileExtension[0] != '.') {
        char* resultExtension = new char[] {'.', '\0'};
        resultExtension = strcat((char*)newFilename, strcat(resultExtension, fileExtension));
        newFilename = resultExtension;
    }
    else {
        newFilename = strcat((char*)newFilename, fileExtension);
    }

    FILE* stream = fopen(newFilename, "w");
    fclose(stream);
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