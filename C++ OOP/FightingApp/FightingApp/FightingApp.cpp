#include <iostream>
#include "Hero.h"
#include <Windows.h>

using namespace std;

void Fight(Hero& h1, Hero& h2) {
    srand(time(0));

    while (h1.hp > 0 && h2.hp > 0) {
        system("cls");

        if (rand() % 3 == 1) {
            h2.Attack(h1);
        }
        else {
            h1.Attack(h2);
        }
    
        h1.ShowHp();
        h2.ShowHp();
        cout << "\n\n";
        Sleep(1000);
    }
}

int main()
{
    Hero h1 = Hero();
    h1.name = (char*)"Ann";
    Hero h2 = Hero(15, 5);
    h2.name = (char*)"Bob";

    Fight(h1, h2);
}