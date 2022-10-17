#pragma once
class Person {
    int age;
    char* name = (char*)"Unknown";

public:
    static int counter;

    Person()
    {
        counter++;
    }

    void setAge(int age);
    int getAge();
    void show();
};