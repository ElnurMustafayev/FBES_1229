#include <iostream>

using namespace std;

//void PrintArray(int arr[3][5]) {
//    for (int x = 0; x < 3; x++) {
//        for (int y = 0; y < 5; y++)
//        {
//            cout << arr[x][y] << " ";
//        }
//        cout << endl;
//    }
//}

void PrintArray(int* arr, int rowsCount, int columnsCount) {
    for (int x = 0; x < rowsCount; x++) {
        for (int y = 0; y < columnsCount; y++)
        {
            int index = (x * columnsCount) + y;
            cout << arr[index] << endl;
            //cout << *(arr + (x * columnsCount) + y) << endl;
        }
        cout << endl;
    }
}


void PrintArray(int** arr, int rowsCount, int columnsCount) {
    for (int x = 0; x < rowsCount; x++) {
        for (int y = 0; y < columnsCount; y++)
        {
            cout << arr[x][y] << "\t";
        }
        cout << endl;
    }
}


int** GetDoubleArray(int* arr, const int length) {
    int** resultArr = new int* [length];

    // init arrays
    for (int x = 0; x < length; x++)
    {
        resultArr[x] = new int[arr[x]];

        // init array's elements
        for (int y = 0; y < arr[x]; y++)
        {
            resultArr[x][y] = y;
            printf("resultArr[%d][%d] = %d\n", x, y, y);
        }
        cout << endl;
    }

    return resultArr;
}



int main()
{
    //int* arr = new int[] {1, 2, 3, 4, 5, 65, 5, 34, 763, 443, 63};
    int arr[10][4];

    cout << sizeof(arr) << endl;

    /*const int length = 3;
    int arr[length]{
        1,5,7
    };

    GetDoubleArray(arr, length);*/

    //int number = 100;
    //int* arr1 = new int[] {1};
    //int* arr2 = new int[] {1, 2};
    //int* arr3 = new int[] {1, 2, 3};

    /*int** arr = new int* [] {
        new int[] {1},
        new int[] {2,3},
        new int[] {4,5,6},
        &number
    };*/


    /*int* arr1 = new int[] {1, 2, 3};
    int* arr2 = new int[] {4, 5, 6};
    int* arr3 = new int[] {7, 8, 9};
    int staticArr[3];

    int** arr = new int*[] {
        arr1,
        arr2,
        arr3,
        staticArr
    };

    PrintArray(arr, 3, 3);*/

    /*
    int number = 100;
    cout << &number << endl;
    cout << arr << endl;
    cout << arr[0] << endl;
    cout << arr[1][2] << endl;

    cout << *(*(arr + 0) + 7) << endl;
    */




    //int arr[3][3]{
    //    {1,2,3},
    //    {1,2,7},
    //    {}
    //};
    ////cout << *(*(arr + 1) + 1) << endl;

    //PrintArray(&arr[0][0], 3, 3);
}