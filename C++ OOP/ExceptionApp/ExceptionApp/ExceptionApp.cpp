#include <iostream>
#include "Exceptions.h"

using namespace std;

int Calculate(int* num1, int* num2) {
    if (num1 == nullptr || num2 == nullptr) {
        string whichIsNullptr = num1 == nullptr ? "num1" : "num2";

        throw ArgumentNullptrException("Argument can not be nullptr!", whichIsNullptr);
    }

    if (num1 == num2) {
        throw ArgumentException("Arguments can not be equal!", "num1 & num2");
    }

    if (*num2 == 0) {
        throw DivisionByZeroException("Division by 0!!!");
    }

    int result = *num1 / *num2;

    if (result == 0) {
        throw Exception("Result is 0 in Calculation!");
    }

    cout << result << endl;

    *num1 = result + 100;

    return result;
}

int main()
{
    int* num1 = new int(10);
    int* num2 = new int(0);


    try {
        int result = Calculate(num1, num2);
    }
    catch (DivisionByZeroException ex) {
        cout << "Error: " << ex.message << endl;
        cout << "This error was sent to ADMIN!!!" << endl;
    }
    catch (ArgumentException ex) {
        ex.GetMessage();
        cout << "Argument exception was sent to analytics..." << endl;
    }
    catch (ArgumentNullptrException ex) {
        ex.GetMessage();
        cout << "Argument nullptr exception was sent to developers..." << endl;
    }
    catch (Exception ex) {
        cout << "Error: " << ex.message << endl;
    }




    /*
    cout << *num1 << endl;
    cout << *num2 << endl;
    */
}