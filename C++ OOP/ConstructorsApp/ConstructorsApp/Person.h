#pragma once
#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <cstring>

using namespace std;

int counter = 0;

class Person {
    char name[30];
    int age = 0;
public:
    // Age
    void setAge(int age) {
        if (age > 0 && age < 100) {
            this->age = age;
        }
    }
    int getAge() {
        return this->age;
    }

    // Name
    void setName(char* name) {
        strcpy(this->name, name);
    }
    char* getName() {
        return this->name;
    }

    Person() {
        counter++;
        cout << "Parametrless Constructor" << endl;
        this->setAge(-1);
        this->setName((char*)"Unknown");
        //cout << Person().getAge() << endl;
        /*age = -1;
        strcpy(name, "Unknown");*/
    }

    Person(int age, char* name) {
        counter++;
        cout << "Parametrized Constructor" << endl;
        this->setAge(age);
        this->setName(name);
    }
};