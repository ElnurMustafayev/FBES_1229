#pragma once

#include <iostream>

using namespace std;

template<typename T>
class ListNode {
public:
	T value;
	ListNode<T>* next = nullptr;
	
	ListNode(T value) : value(value) {}
};



template<typename T>
class LinkedList {
	ListNode<T>* head = nullptr;
	ListNode<T>* tail = nullptr;
	int size = 0;

public:
	void Push(T newElement) {
		ListNode<T>* newNode = new ListNode<T>(newElement);

		// first
		if (this->head == nullptr) {
			this->head = newNode;
			this->tail = newNode;
		}
		// not first
		else {
			this->tail->next = newNode;
			this->tail = newNode;

			/*ListNode<T>* cursor = this->head;

			while (cursor->next != nullptr) {
				cursor = cursor->next;
			}

			cursor->next = newNode;*/
		}

		this->size++;
	}

	void Print() {
		ListNode<T>* cursor = this->head;

		while (cursor != nullptr) {
			cout << cursor->value << endl;
			cursor = cursor->next;
		}
	}
};