#include <iostream>
#include <vector>

using namespace std;

//template<typename T>
//bool InsertInArray(T* arr, int length, T newItem) {}
//
//template<typename T>
//int InsertInArray(T* arr, int length, T start, T end) {}
//
//template<typename T>
//char* InsertInArray(T* arr, int length, T* newItems, int length2) {}


//template<typename T>
//class MyClass {
//public:
//    T value;
//
//    //template<typename TArg>
//    bool isEqual(MyClass obj) {
//        return this->value == obj.value;
//    }
//};

//template<typename T1, typename T2>
//int Func() {
//    return sizeof(T1) + sizeof(T2);
//}




template<typename T>
class Array {
    T* arr;
    int length = 0;

public:
    void Print() {
        if (arr == nullptr || length == 0)
            return;

        for (int i = 0; i < this->length; i++)
        {
            cout << this->arr[i] << endl;
        }
    }

    void Add(T newItem) {
        T* temp = new T[this->length + 1];

        for (int i = 0; i < this->length; i++)
        {
            temp[i] = this->arr[i];
        }

        delete[] this->arr;

        temp[this->length] = newItem;

        this->arr = temp;

        this->length++;
    }
};





int main()
{
    //vector<int> v = vector<int>();

    /*Array<int> arr = Array<int>();
    arr.Add(1);
    arr.Add(2);
    arr.Add(3);
    arr.Add(4);
    arr.Add(5);

    arr.Print();*/


    //Func<bool, int>()

    /*MyClass<unsigned int> obj1 = MyClass<unsigned int>();
    obj1.value = -10;

    MyClass<short> obj2 = MyClass<short>();
    obj2.value = obj1.value;*/

    //cout << (short)obj1.value << endl;
    //cout << (short)obj2.value << endl;

    //cout << (obj1.value == obj2.value) << endl;



    /*
    MyClass obj1 = MyClass();
    obj1.value = 123;

    MyClass obj2 = MyClass();
    obj2.value = 100;

    cout << obj1.isEqual(obj2) << endl;
    */





    /*cout << Func<int>() << endl;
    cout << Func<bool>() << endl;*/

}