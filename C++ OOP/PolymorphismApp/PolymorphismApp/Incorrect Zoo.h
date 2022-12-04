#pragma once

namespace IncorrectZoo {

    class Dog {
    public:
        string name;

        Dog() : name("Unknown") {}
        Dog(string name) : name(name) {}
    };

    class Cat {
    public:
        string name;

        Cat() : name("Unknown") {}
        Cat(string name) : name(name) {}
    };

    class Turtle {
    public:
        string name;

        Turtle() : name("Unknown") {}
        Turtle(string name) : name(name) {}
    };

    class Zoo {
    public:
        int dogsCount = 0;
        Dog* dogs;

        int catsCount = 0;
        Cat* cats;

        int turtleCount = 0;
        Turtle* turtles;

        Zoo()
        {
            dogs = new Dog[dogsCount = 2]{
                Dog("Arch"),
                Dog("Test"),
            };

            cats = new Cat[catsCount = 3]{
                Cat("Rijik"),
                Cat("Umka"),
                Cat("Leopild"),
            };

            turtles = new Turtle[turtleCount = 1]{
                Turtle("Leonardo")
            };
        }

        void ToFeed() {
            for (int i = 0; i < dogsCount; i++)
            {
                cout << dogs[i].name << ": nyam-nyam. THANKS!!!" << endl;
            }

            for (int i = 0; i < catsCount; i++)
            {
                cout << cats[i].name << ": ok..." << endl;
            }

            for (int i = 0; i < turtleCount; i++)
            {
                cout << turtles[i].name << ": loading..." << endl;
            }
        }
    };

}