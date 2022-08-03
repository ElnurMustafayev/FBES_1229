//#define _CRT_SECURE_NO_WARNINGS
#include <stdlib.h>
#include <iostream>
#include "Functions.h"

using namespace std;

int* GetArray() {
    return new int[10];
}

void InfinityRecursion() {
    InfinityRecursion();
}

int main()
{
    /*int length = 2;

    int* arr1 = new int[length] {};
    delete[] arr1;

    int* arr2 = (int*)malloc(length * sizeof(int));
    free(arr2);*/


    //try {
    //    int age = 0;
    //    cin >> age;

    //    if (age < 0) {
    //        //throw age;
    //        throw "Age can not be less than zero!";
    //    }
    //}
    //catch (int errorAge) {
    //    cout << "Incorrect age: " << errorAge << endl;
    //}
    //catch (char message[100]) {
    //    cout << "Error message: " << message << endl;
    //}

    /*cout << "Start" << endl;

    try {
        InfinityRecursion();
    }
    catch (int ex) {
        cout << ex << endl;
    }

    cout << "End" << endl;*/

    //cout << "Start" << endl;

    //int num = 0;

    //try {
    //    /*num = ConvertCharToInt('8');
    //    cout << num << endl;
    //    num = ConvertCharToInt('3');
    //    cout << num << endl;*/
    //    num = ConvertCharToInt('b');
    //    cout << num << endl;
    //}
    //catch (const char exceptionMsg[]) {
    //    cout << "Error: " << exceptionMsg << endl;
    //    exit(-123);
    //}

    //cout << num + 100 << endl;

    //cout << "End" << endl;


    try {
        int* arr = Convert((char*)"23137");
        Print(arr, 5);
    }
    catch (const char exceptionMsg[]) {
        cout << "Error: " << exceptionMsg << endl;
    }
}