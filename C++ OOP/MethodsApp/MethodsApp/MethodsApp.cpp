#include <iostream>
#include "Calc.h"

using namespace std;

class MyClass {
    //int* x = new int(100);
public:
     int* x;

    int Func(int x) {
        x = *(this->x);

        *(this->x) = x;

        return x;
    }

    /*bool Func(int x) {
        return x == *(this->x);
    }*/
};

int main()
{
    /*MyClass obj1 = MyClass();
    obj1.x = new int(100);
    MyClass obj2 = obj1;

    *obj1.x += 10;

    cout << obj2.Func(*obj1.x);*/


    /*MyClass* obj = new MyClass();
    MyClass* obj2 = obj;

    obj->Func();
    obj2->Func();*/



    /*Calc calc1 = Calc();

    calc1.x = 5;
    calc1.y = 7;

    cout << "calc1 - X: " << calc1.x << endl;
    cout << "calc1 - Y: " << calc1.y << endl;
    
    cout << "calc1 - Sum: " << calc1.Sum() << endl;



    Calc calc2 = Calc();

    cout << "calc2 - X: " << calc2.x << endl;
    cout << "calc2 - Y: " << calc2.y << endl;

    cout << "calc2 - Mult: " << calc2.Mult() << endl;*/
}