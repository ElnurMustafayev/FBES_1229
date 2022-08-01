#include <iostream>
#include <exception>

using namespace std;

int main()
{
    //throw 123;



    //try {
    //    //throw 200;

    //    if(false)
    //        throw 404;

    //    throw 500;
    //}
    //catch(int errorCode) {
    //    cout << "Error code is: " << errorCode << endl;
    //}

    throw 123;

    try {
        throw "test";
        char* word = new char[] { 'q', 'w', 'e', 'r', 't', 'y'};
        throw word;
    }
    catch (int errorCode) {
        cout << "Error code is: " << errorCode << endl;
    }
    catch (char exceptionSymbol) {
        cout << "Symbol: " << exceptionSymbol << endl;
    }
    catch (char* exceptionStr) {
        cout << "dynamic Exception message: " << exceptionStr << endl;
    }
    catch (const char exceptionStr[]) {
        cout << "static Exception message: " << exceptionStr << endl;
    }
}