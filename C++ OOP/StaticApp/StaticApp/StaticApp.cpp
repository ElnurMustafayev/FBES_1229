#include <iostream>
#include "Person.h"

using namespace std;

//void CallsCounter() {
//    static int counter = 0;
//    cout << "I was called " << ++counter << " times" << endl;
//}

//void IncrementNum(int value) {
//    static int num = 0;
//
//    num += value;
//
//    cout << &value << endl;
//    cout << num << endl;
//}



int main()
{
    /*IncrementNum(5);
    IncrementNum(10);
    IncrementNum(15);*/

    /*CallsCounter();
    CallsCounter();
    CallsCounter();*/

    Person p1 = Person();
    Person p2 = Person();
    Person p3 = Person();

    cout << p3.counter << endl;
    cout << Person::counter << endl;

}