#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include "Number.h"

using namespace std;

//class String {
//public:
//    char* text;
//
//    String(char* str) {
//        this->text = str;
//    }
//};

int main()
{


    /*Number num = 100;
    num = num + 5;
    num += 100;

    cout << num.value << endl;*/
    


    //num + 5;
    //cout << num.value << endl;






    /*String str = (char*)"qwerty";

    str += "test";

    cout << str.text << endl;*/

    /*string str = "qwerty";

    str += "test";

    cout << str << endl;*/

    /*char* word = new char[] {
        'q', 'q', 'q'
    };
    word += (char*)"qwe";*/


    /*Number num1 = 123;
    Number num2 = 321;

    cout << (num1 == num2) << endl;*/

    //cout << (num1 == num2) << endl;
    //cout << (num1 != num2) << endl;


    String str1 = "One";
    String str2 = "Two";

    str1 += str2;

    cout << str1.text << endl;

}