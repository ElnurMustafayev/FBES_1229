#include <iostream>

using namespace std;

int main()
{
    /*
    double usd = 1.7;
    double euro = 1.8;
    double rub = 0.0295;

    cout << "Select currency" << "\n\n";

    cout << "Press: " << endl;
    cout << "'1' for 'USD': " << endl;
    cout << "'2' for 'EURO': " << endl;
    cout << "'3' for 'RUB': " << endl;

    short select;

    cin >> select;

    switch (select) {
    case 1:
    case -1:
    {
        int number = 100;
        cout << "USD" << endl;
        cout << usd << endl;
        break;
    }
    case 2:
    case -2:
        //cout << number << endl;
        cout << "EURO" << endl;
        cout << euro << endl;
        break;
    case 3:
    case -3:
        cout << "RUB" << endl;
        cout << rub << endl;
        break;
    default:
        cout << "Selected number is incorrect!" << endl;
        break;
    }
    */


    /*
    if (select == 1) {
        cout << "USD" << endl;
    }
    else if (select == 2) {
        cout << "EURO" << endl;
    }
    else if (select == 3) {
        cout << "RUB" << endl;
    }
    else {
        cout << "Selected number is incorrect!" << endl;
    }
    */



    int number;
    int factorial = 1;
    cout << "Input number: ", cin >> number;

    switch (number) {
    case 10:
        factorial *= 10;
    case 9:
        factorial *= 9;
    case 8:
        factorial *= 8;
    case 7:
        factorial *= 7;
    case 6:
        factorial *= 6;
    case 5:
        factorial *= 5;
    case 4:
        factorial *= 4;
    case 3:
        factorial *= 3;
    case 2:
        factorial *= 2;
    case 1:
    case 0:
        cout << factorial;
        break;
    default:
        cout << "Incorrect number!" << endl;
        break;
    }
}