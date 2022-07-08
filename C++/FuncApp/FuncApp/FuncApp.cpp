#include <iostream>

using namespace std;

//void MyFunction() {
//    int number = 100;
//
//    cout << number << endl;
//
//    number++;
//}


//void MyFunction() {
//    int number = 90;
//
//    if (number < 100)
//        cout << "small!" << endl;
//
//    cout << "End" << endl;
//}



//void MyFunction() {
//    
//    while (true)
//        cout << "while" << endl;
//
//    for (;;)
//        cout << "for" << endl;
//
//    if(true)
//        cout << "if" << endl;
//
//}



//void MyFunction() {
//    for (int x = 0; x < 3; x++) {
//        cout << "* * *" << endl;
//    }
//}



//void DrawSquare(int num) {
//    cout << num << endl;
//}


//void DrawSquare(int num) {
//    for (int x = 0; x < num; x++) {
//        for (int y = 0; y < num; y++) {
//            cout << "* ";
//        }
//        cout << endl;
//    }
//}





//void DrawSquare(char symbol) {
//    for (int x = 0; x < 5; x++) {
//        for (int y = 0; y < 5; y++) {
//            cout << symbol << " ";
//        }
//        cout << endl;
//    }
//}




//void DrawSquare(bool hasSpace) {
//    for (int x = 0; x < 3; x++) {
//        for (int y = 0; y < 3; y++) {
//
//            cout << (hasSpace ? "* " : "*");
//
//            /*if (hasSpace)
//                cout << "* ";
//            else
//                cout << "*";*/
//        }
//        cout << endl;
//    }
//}





//void DrawSquare(int row, int column, char symbol) {
//    for (int x = 0; x < column; x++) {
//        for (int y = 0; y < row; y++) {
//            cout << symbol << " ";
//        }
//        cout << endl;
//    }
//}



//void IsAdult(int age) {
//    if (age >= 18)
//        cout << "User is adult!" << endl;
//    else
//        cout << "User is not adult!" << endl;
//}




//bool IsAdult(int age) {
//    /*bool check = true;
//    return check;*/
//    cout << "Start" << endl;
//
//    if (age >= 18)
//        return true;
//    else
//        return false;
//
//    cout << "End" << endl;
//}



//bool InfinityLoop() {
//    cout << "Start" << endl;
//    while (true) {
//        return true;
//    }
//    cout << "End" << endl;
//}




//bool IsAdult(int age) {
//    return age >= 18;
//    
//    /*if (age >= 18)
//        return true;
//    else
//        return false;*/
//}




//void IsPrimary(int num) {
//    bool prim = true;
//
//    for (int i = 2; i < (num / 2) + 1; i++)
//    {
//        if (num % i == 0) {
//            prim = false;
//            break;
//        }
//    }
//
//    if (prim)
//        cout << "Primary" << endl;
//}





//bool IsPrimary(int num) {
//    bool prim = true;
//
//    for (int i = 2; i < num; i++)
//    {
//        if (num % i == 0) {
//            prim = false;
//            break;
//        }
//    }
//
//    return prim;
//}




//bool Func(int age) {
//    int num = 123;
//    return num;
//}





//void SayYourAge(bool hasVisa, int age = 18) {
//    if (hasVisa == false)
//        return;
//
//    cout << "You are " << age << " years old" << endl;
//}





int Func(int num1, int num2 = 10, char symbol = 'a') {
    num1 = (num2 == 10 ? num2 : num1);
    for (int i = 1; i < num1; i++) {
        cout << (int)(num2 + symbol) << endl;
        if (i % 5 == 0)
            return 1;
    }
    //return 0;
}

void SayHello();
int GetNegativeNumber(int number);

void main()
{
    //cout << Func(1);
    cout << Func(1, 5) << endl;

    //CallFunc();
    /*
    SayYourAge(true);
    SayYourAge(false, 10);
    */
    

    //char symbol = 'a';
    //MyFunction(symbol);

    //DrawSquare(5);

    //DrawSquare('@');

    //DrawSquare(5, 10, 'a');

    //IsAdult(15);

    //InfinityLoop();

    //cout << IsAdult(15) << endl;

    /*bool result = Func(7);
    cout << result << endl;*/
}

void SayHello() {
    cout << "Hello World!" << endl;
}

int GetNegativeNumber(int number) {
    return (number <= 0) ? number : -number;
}