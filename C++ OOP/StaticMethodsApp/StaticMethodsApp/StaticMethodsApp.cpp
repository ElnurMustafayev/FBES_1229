#include <iostream>

using namespace std;

//class Test {
//    double num1;    // 8
//
//    char symbol1;   // 1 + (7)
//
//    long long num2; // 8
//
//    bool check1;    // 1 + (7)
//
//    char* ptr;      // 8
//
//    short num4;     
//    int num5;       // 2 + 4 + (2)
//
//    float num6;     // 4 + (4)
//};




//class Test {
//    int num = 0;
//public:
//    Test(int num)
//    {
//        this->num = num;
//    }
//
//    /*void Func() {
//        this->num;
//        cout << "Func" << endl;
//    }*/
//
//    static void Func() {
//        cout << "Func" << endl;
//    }
//
//};


class Calc {
    int x;
    int y;
public:
    Calc(int x, int y)
    {
        this->x = x;
        this->y = y;
    }

    static double Sum(double x, double y) {
        return x + y;
    }
    
    static double Minus(double x, double y) {
        return x - y;
    }
};

int main()
{
    /*Calc calc = Calc();

    cout << calc.Sum(10, 5) << endl;*/

    //cout << Calc::Sum(10, 5) << endl;






    cout << Calc::Sum(10, 5) << endl;
    cout << Calc::Sum(454,7897) << endl;
}