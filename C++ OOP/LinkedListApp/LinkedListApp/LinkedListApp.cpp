#include <iostream>
#include "List.h"

using namespace std;

int main()
{
    LinkedList<int> list = LinkedList<int>();

    list.Push(11);
    list.Push(22);
    list.Push(33);

    list.Print();
}