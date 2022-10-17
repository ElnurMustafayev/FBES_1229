#include "Person.h"
#include <iostream>

using namespace std;

int Person::counter = 0;

void Person::setAge(int age) {
    if (age > 0 && age < 100) {
        this->age = age;
    }
}

int Person::getAge() {
    return this->age;
}

void Person::show() {
    cout << "Name: " << this->name << endl;
    cout << "Age: " << this->age << endl;
}