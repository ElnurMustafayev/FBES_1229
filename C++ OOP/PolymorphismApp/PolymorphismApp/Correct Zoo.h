#pragma once

namespace CorrectZoo {
    class Animal {
    public:
        string name;

        Animal() : Animal("Unknown") {}
        Animal(string name) : name(name) {}

        virtual void Say() {
            cout << "..." << endl;
        }
    };

    class Cat : public Animal {
    public:
        Cat() : Animal("Unknown") {}
        Cat(string name) : Animal(name) {}

        void Say() override {
            cout << "meow" << endl;
        }
    };
}