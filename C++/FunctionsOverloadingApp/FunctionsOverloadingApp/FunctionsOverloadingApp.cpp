#include <iostream>
#include <cstring>

using namespace std;

// function overloading (перегрузка функций)
int UppersCount(char symbol1, char symbol2, char symbol3) {
    return ('A' <= symbol1 && symbol1 <= 'Z') +
        ('A' <= symbol2 && symbol2 <= 'Z') +
        ('A' <= symbol3 && symbol3 <= 'Z');
}

int UppersCount(char word[]) {
    int count = 0;

    for (int i = 0; word[i] != '\0'; i++)
        count += ('A' <= word[i] && word[i] <= 'Z');

    return count;
}

int GetEvensCount(int numbers[], int length) {
    int counter = 0;

    for (int i = 0; i < length; counter += !(numbers[i++] % 2)) {}

    return counter;
}

int main()
{
    const int length = 7;
    char word[length] = "QweRty";

    cout << UppersCount(word) << endl;
    cout << UppersCount('a', 'A', 'V') << endl;

    const int lenght = 7;
    int nums[lenght] = { 1,2,3,4,5,76,5 };
    cout << GetEvensCount(nums, lenght) << endl;
}