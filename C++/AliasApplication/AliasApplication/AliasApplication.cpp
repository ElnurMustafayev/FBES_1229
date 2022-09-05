#include <iostream>

using namespace std;

void ChangeNumber(int& num) {
    cout << ++num << endl;
}

enum STATUSES : int {
    active = 10,
    blocked = 5
};

template<typename T1, typename T2>
void Flip(T1& left, T2 right) {
    left = right;
}

int main()
{
    /*int num = 100;

    ChangeNumber(num);

    cout << num << endl;*/


    /*int num = 100;
    int& numAlias = num;
    numAlias = 555;
    cout << numAlias << endl;*/

    /*int* numPtr = &num;
    *numPtr = 777;
    cout << *numPtr << endl;*/

    /*STATUSES status = STATUSES::active;

    STATUSES& statusLink = status;

    statusLink = STATUSES::blocked;

    cout << status << endl;
    cout << statusLink << endl;*/


    /*double num1 = 123.23;
    int num2 = 321;
    Flip(num1, num2);

    cout << num1 << endl;
    cout << num2 << endl;*/


    /*int num = 123;
    int& numLink = num;

    cout << (float&)numLink << endl;*/
}