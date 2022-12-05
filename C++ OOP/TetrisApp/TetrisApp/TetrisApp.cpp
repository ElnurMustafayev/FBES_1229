#include <iostream>

using namespace std;

//class A {
//public:
//    int num1;
//    virtual void Func() {
//        cout << "A" << endl;
//    }
//};
//
//class B : public A {
//public:
//    int num2;
//    /*void Func() override {
//        cout << "B" << endl;
//    }*/
//};
//
//class C : public B {
//public:
//    int num2;
//    /*void Func() override {
//        cout << "B" << endl;
//    }*/
//};




class Square {
public:
    virtual double Perimeter() {
        return 0;
    }

    virtual string GetName() {
        return "Figure";
    }
};


class Rectangle : public Square {
    int side = 0;

public:
    int getSide() const {
        return side;
    }

    void setSide(const int side) {
        if (side > 0) {
            this->side = side;
        }
    }

    Rectangle(int side) {
        this->setSide(side);
    }

    double Perimeter() override {
        return side * 4;
    }

    string GetName() override {
        return "Rectangle";
    }
};

class Circle : public Square {
public:
    const double pi = 3.14;
    int radius;

    Circle(int radius) : radius(radius) {}

    double Perimeter() override {
        return 2 * pi * radius;
    }

    string GetName() override {
        return "Circle";
    }
};


void PrintPerimeter(Square* s) {
    cout << s->GetName() << "'s perimeter: " << s->Perimeter() << " sm" << endl;
}


int main()
{
    PrintPerimeter(new Circle(5));
}