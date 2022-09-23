#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

using namespace std;

int* temp = new int(123);

struct Person {
    char* name = (char*)"Unknown";
    int age = -1;
};

int main()
{
    /*Person p1 = Person();
    Person p2 = Person();

    *(p1.age) = 67;

    cout << *p1.age << endl;
    cout << *p2.age << endl;*/

    /*Person people[3] = {
        Person(),
        Person()
    };

    people[1].name = (char*)"Bob";

    people[0] = people[1];

    people[1].name = (char*)"Test";
    people[0] = people[1];

    cout << people[0].name << endl;*/

    /*people[0].name = (char*)"Test";

    cout << people[0].name << endl;*/




    /*Person p1 = Person();
    Person p2 = Person();

    p1.name = (char*)"One";
    p2 = p1;

    p2.name = (char*)"Two";
    p1 = p2;

    cout << p1.name << endl;
    cout << p2.name << endl;*/



    /*Person* p2 = new Person();
    p2->name = (char*)"Test";

    cout << p2->name << endl;*/
    
    /*Person p = Person();
    Person* pPtr = &p;*/

    /*Person p1 = Person();
    p1.age;
    Person* p2 = new Person();
    p2->age;*/


    /*Person* p1 = new Person();
    Person* p2 = new Person();

    p1->name = (char*)"One";

    p2 = p1;

    p2->name = (char*)"Two";

    cout << p1->name << endl;*/

}