#include <iostream>
#include <vector>

using namespace std;

void MyFunc(int num, string message) {
    cout << message << ": " << num << endl;
}

bool CheckNumberIsPositive(int num) {
    return num > 0;
}

bool CheckNumberIsNegative(int num) {
    return num < 0;
}



bool CheckName(string name) {
    if (name.empty() == true) {
        return false;
    }
    else if (toupper(name[0]) != name[0]) {
        return false;
    }
    else {
        return true;
    }
}


void ShowNumbers(vector<int> nums, bool(*numChecker)(int)) {
    for (int num : nums) {
        if (numChecker(num) == true)
            cout << num << endl;
    }
}

template<typename T>
void ShowIf(vector<T> collection, bool(*checker)(T)) {
    for (T item : collection) {
        if (checker(item) == true)
            cout << item << endl;
    }
}

int main()
{
    vector<int> nums = {
        12,45,-45,0,77,-8,-100,89,66,0,55,-1
    };
    cout << "Negatives: " << endl;
    ShowIf(nums, CheckNumberIsNegative);

    cout << "Positivs: " << endl;
    ShowIf(nums, CheckNumberIsPositive);

    vector<string> names = {
        "Rufat",
        "Elnur",
        "Bob",
        "test",
        "Ann",
        "john",
    };
    ShowIf(names, CheckName);

    /*bool(*numChecker)(int);

    numChecker = false 
        ? CheckNumberIsPositive 
        : CheckNumberIsNegative;

    int num;
    cin >> num;
    cout << numChecker(num) << endl;*/



    /*void(*func)(int, string);
    func = MyFunc;
    func(123, "Test");
    func(-45, "Salam");
    func(777, "Bob");*/



    //int num = 100;
    //int* numPtr = &num;
    //int& numAlias = num;
    //string str = string("qwerty");
}