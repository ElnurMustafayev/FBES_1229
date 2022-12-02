#include <iostream>
#include "Composition.h"
#include "Aggregation.h"

using namespace std;
using namespace agr;

int main()
{
    comp::Person p = comp::Person(90);
    //p.heart = comp::Heart();

    vector<Person>* childer = new vector<Person>();
    Person c1 = Person("one", "one");
    childer->push_back(c1);
    Person c2 = Person("two", "two");
    childer->push_back(c2);
    Person c3 = Person("three", "three");
    childer->push_back(c3);



    Person* wife = new Person("Alexis", "Ren");
    Person* husband = new Person("Bob", "Fisher");

    Family family = Family();

    family.wife = wife;
    family.husband = husband;

    family.SetChildren(childer);

    family.KillLastChild();

    //childer->pop_back();

    /*family.husband = nullptr;
    family.husband = new Person("Test", "Test");*/
}