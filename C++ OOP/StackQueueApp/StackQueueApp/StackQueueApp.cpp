#include <iostream>
#include <stack>
#include <vector>
#include <queue>

using namespace std;

class MyArr {
	int* arr;

public:
	MyArr(int capacity = 10)
	{
		arr = new int[capacity] {};
	}

	int& operator [](int index) {
		return this->arr[index];
	}

	void operator ()(string str1, string str2) {
		cout << str1 << endl;
		cout << str2 << endl;
	}
};


struct Operation {
	string name;

	Operation(string name) : name(name) {}

	void Do() {
		if (this->name.empty())
			throw 100;

		cout << "Do " << this->name << "..." << endl;
	}

	void Revert() {
		cout << "Revert " << this->name << "..." << endl;
	}
};

stack<Operation> operations = stack<Operation>();

int main()
{
	/*const int length = 5;

	Operation ops[length]{
		Operation("one"),
		Operation("two"),
		Operation("three"),
		Operation("four"),
		Operation("five")
	};

	for (int i = 0; i < length; i++)
	{
		try {
			ops[i].Do();
			operations.push(ops[i]);
		}
		catch (int code) {
			cout << "Can not proceed operation: " << ops[i].name << endl;
			cout << "Error code: " << code << "\n\n";

			cout << "Start reverting..." << endl;
			while (operations.empty() == false)
			{
				operations.top().Revert();
				operations.pop();
			}
			break;
		}
	}*/

	

	/*queue<int> myQueue = queue<int>();

	myQueue.push(11);
	myQueue.push(22);
	myQueue.push(33);
	myQueue.push(44);
	myQueue.push(55);


	cout << myQueue.back() << endl;
	myQueue.pop();*/



	/*MyArr arr = MyArr(100);

	arr[20] = 123;

	cout << arr[20] << endl;
	arr("Hello", "World");*/

	/*stack<int> myStack = stack<int>();

	myStack.push(11);
	myStack.push(22);
	myStack.push(33);

	cout << myStack.top() << endl;
	myStack.pop();
	cout << myStack.top() << endl;
	myStack.pop();
	cout << myStack.top() << endl;
	myStack.pop();*/

	//cout << myStack[0] << endl;
}