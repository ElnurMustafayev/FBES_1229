#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <vector>
#include "Person.h"

using namespace std;


template<typename T>
class Array {
    T* arr;
    int length = 0;

public:

    Array(int start, int end) {
        for (int i = start; i <= end; i++)
        {
            this->Add(i);
        }
    }

    void Print() {
        if (arr == nullptr || length == 0)
            return;

        for (int i = 0; i < this->length; i++)
        {
            cout << this->arr[i] << endl;
        }
    }

    void Add(T newItem) {
        T* temp = new T[this->length + 1];

        for (int i = 0; i < this->length; i++)
        {
            temp[i] = this->arr[i];
        }

        delete[] this->arr;

        temp[this->length] = newItem;

        this->arr = temp;

        this->length++;
    }
};


int getNumber(int num) {
    cout << "FIELD" << num << endl;
    return 100;
}

class MyClass {
public:
    int num1 = getNumber(1);
    int num2 = getNumber(2);

    MyClass()
    {
        cout << "CTOR" << endl;
    }
};




int main()
{
    MyClass();
    /*cout << "Start" << endl;

    Person p1 = Person();
    Person p2 = Person();
    Person p3 = Person();
    Person p4 = Person(15, (char*)"Umid");

    cout << "Age: " << p1.getAge() << endl;
    cout << "Name: " << p4.getName() << endl;

    cout << "End" << endl;*/

    /*Person* people = new Person[5]{
        Person(),
        Person(18, (char*)"Rufat"),
        Person(-45, (char*)"Bob"),
        Person(),
    };

    cout << counter << endl;*/

    //cout << Person(123, (char*)"Rufat").getAge() << endl;

    //Person p1 = Person();

    //cout << Person().getAge() << endl;


    /*vector<int> arr = vector<int>();

    for (size_t i = 0; i < 10; i++)
    {
        arr.push_back(rand());
    }

    for (int i = 0; i < arr.size(); i++)
    {
        cout << arr.at(i) << endl;
    } */

    /*Array<int> arr = Array<int>(5, 10);

    arr.Print();*/
}