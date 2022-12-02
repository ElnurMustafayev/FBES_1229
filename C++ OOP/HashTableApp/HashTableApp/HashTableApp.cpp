#include "HashTable.h"

#include <iostream>
using namespace std;




int main()
{
    HashSet<int> myHashSet = HashSet<int>(5);

    myHashSet.Add(125);     // 0
    myHashSet.Add(666);     // 1
    myHashSet.Add(1254);    // 4
    myHashSet.Add(346);     // 1
    myHashSet.Add(600);     // 0
    myHashSet.Add(568);     // 3
    myHashSet.Add(352);     // 2
    myHashSet.Add(63635);   // 0
    myHashSet.Add(12512);   // 2
    myHashSet.Add(5363);    // 3
    myHashSet.Add(111);     // 1
    myHashSet.Add(421);     // 1

    // 0 - 3
    // 1 - 4
    // 2 - 2
    // 3 - 2
    // 4 - 1

    myHashSet.Show();
}