#include <iostream>

using namespace std;

class Person {
    int age;

public:
    char* name;

    // setter
    void setAge(int age) {
        if (age > 0 && age < 100) {
            this->age = age;
        }
    }

    // getter
    int getAge() {
        return this->age;
    }

    void show() {
        cout << "Name: " << this->name << endl;
        cout << "Age: " << this->age << endl;
    }
};


class Car {
    double maxSpeed;
    double speed;
    char* name;

public:
    // accessors for name
    char* getName() {
        if (this->name == nullptr)
            return (char*)' ';

        return this->name;
    }
    void setName(char* name) {
        this->name = name;
    }

    // accessors for maxSpeed
    double getMaxSpeed() {
        return this->maxSpeed;
    }
    void setMaxSpeed(double maxSpeed) {
        if (maxSpeed >= 0) {
            this->maxSpeed = maxSpeed;
        }
    }

    // accessors for speed
    double getSpeed() {
        return this->speed;
    }
    double setSpeed(double speed) {
        if (speed > 0 && speed < this->getMaxSpeed()) {
            this->speed = speed;
        }
    }
};



int main()
{
    /*Person p1 = Person();
    p1.name = (char*)"Bob";

    p1.setAge(18);
    p1.setAge(-10);

    if (p1.getAge() < 18)
        exit(0);*/


    /*do {
        cin >> p1.age;
    } while (p1.age < 0 || p1.age > 100);*/



    /*Car car = Car();
    car.getName();*/
}