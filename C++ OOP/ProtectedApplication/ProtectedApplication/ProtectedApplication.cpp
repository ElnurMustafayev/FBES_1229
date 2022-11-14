#include <iostream>
#include "Classes.h"

using namespace std;

int main()
{
	/*ArrayBase<int> array = ArrayBase<int>();

	array.Add(1);
	array.Add(2);
	array.Add(3);

	array.Delete(1);
	
	array.Show();

	cout << array.Size() << endl;*/

	MyVector<int> vector = MyVector<int>(4);

	vector.Push(1);
	vector.Push(2);
	vector.Push(3);
	vector.Push(3);
	vector.Push(2);
	vector.Push(42);
	vector.Push(264);
	vector.Push(322);

	vector.Pop();
	vector.Pop();
	vector.Pop();
	vector.Pop();

	vector.Print();
}