#pragma once

#include <iostream>

using namespace std;

//class A {
//public:
//	int num = 123;
//};
//
//class B : public A {
//	B()
//	{
//		this->num = 123123;
//	}
//};



//class A {
//public:
//	int num = 123;
//
//public:
//	A()
//	{
//		this->num = 123;
//	}
//};
//
//class B : protected A {
//public:
//	B()
//	{
//		this->num;
//	}
//};
//
//class C : private B {
//public:
//	C()
//	{
//		this->num = 123;
//	}
//};
//
//class D : public C {
//public:
//	D()
//	{
//		// this->num = 24214;  // error
//	}
//};






template<class T>
class ArrayBase {
protected:
	int size = 0;
	T* arr = nullptr;

public:
	int Size() {
		return size;
	}

	void Add(T newElement) {
		T* newArr = new T[size + 1];

		for (int i = 0; i < size; i++)
		{
			newArr[i] = arr[i];
		}

		delete[] arr;

		newArr[size++] = newElement;

		this->arr = newArr;
	}


	void Delete(int index) {
		if (index < 0 || index >= size)
			return;

		T* newArr = new T[size - 1];

		for (int i = 0; i < index; i++)
			newArr[i] = arr[i];

		for (int i = index; i < size; i++)
			newArr[i] = arr[i];

		delete[] arr;

		this->arr = newArr;

		size--;
	}

	void Show() {
		for (int i = 0; i < size; i++)
		{
			cout << arr[i] << endl;
		}
		cout << endl;
	}
};


template<class T>
class MyVector : private ArrayBase<T> {
	int capacity = 0;
	int step;

public:
	void SetCapacity(int capacity) {
		if (capacity > this->capacity)
			this->capacity = capacity;
	}

	int GetCapacity() {
		return this->capacity;
	}

	MyVector(int capacity = 3)
	{
		this->SetCapacity(capacity);
		this->step = this->GetCapacity();
		this->arr = new T[this->GetCapacity()]{};
		this->size = 0;
	}

	void Push(int newElement) {
		if (this->size == this->GetCapacity()) {
			this->SetCapacity(this->GetCapacity() + this->step);
			this->RenewArray();
		}

		this->arr[this->size++] = newElement;
	}

	void Pop() {
		this->size--;
	}

	void Print() {
		for (int i = 0; i < this->size; i++)
		{
			cout << this->arr[i] << endl;
		}
		cout << endl;
	}

private:
	void RenewArray() {
		T* newArray = new T[this->GetCapacity()]{};

		for (int i = 0; i < this->size; i++)
		{
			newArray[i] = this->arr[i];
		}

		delete[] this->arr;

		this->arr = newArray;

		cout << "Array was renewed!" << endl;
		cout << "Capasity: " << this->GetCapacity() << endl;
		cout << "Size: " << this->size << "\n\n";
	}
};