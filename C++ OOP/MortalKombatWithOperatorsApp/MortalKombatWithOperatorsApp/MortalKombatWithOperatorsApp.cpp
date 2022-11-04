#include <iostream>
#include "Hero.h"

using namespace std;

// 1.1 Goro.
// 1.2 Johnny Cage.
// 1.3 Kano.
// 1.4 Liu Kang.
// 1.5 Raiden.
// 1.6 Reptile.
// 1.7 Scorpion.
// 1.8 Shang Tsung.

int main()
{
    Hero goro = Hero("Goro", 70, 70);
    Hero raiden = Hero("Raiden", 30, 10);
    raiden.SetHp(300);
    Hero kano = Hero("Kano", 10, 20);
    kano.SetHp(200);

    for (int i = 0; i < 3; i++)
    {
        (goro - raiden) - kano;

        //raiden -= 10;
        //kano -= 30;

        cout << goro.GetHp() << " : " << raiden.GetHp() << " : " << kano.GetHp() << endl;
    }
}