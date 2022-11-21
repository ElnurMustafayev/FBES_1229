#pragma once

#include <iostream>
#include "Exceptions.h"

using namespace std;


enum ListNodeType {
	head, tail
};


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
	void Remove(int index) {
		if (index < 0 || index >= this->size || this->size == 0) {
			throw IndexOutOfRangeException(index, "Incorrect Index in Remove!");
		}

		if (this->size == 1) {
			delete this->head;
			this->head = nullptr;
			this->tail = nullptr;
		}
		else if (index == 0) {
			ListNode<T>* temp = this->head->next;
			delete this->head;

			this->head = temp;
		}
		else if (index == this->size - 1) {
			ListNode<T>* cursor = this->head;

			for (size_t i = 1; i < this->size - 1; i++)
			{
				cursor = cursor->next;
			}
			cursor->next = nullptr;

			delete this->tail;

			this->tail = cursor;
		}
		else {
			ListNode<T>* cursor = this->head;

			for (size_t i = 0; i < index - 1; i++)
			{
				cursor = cursor->next;
			}

			ListNode<T>* toDelete = cursor->next;

			cursor->next = cursor->next->next;

			delete toDelete;
		}

		this->size--;
	}


	void Insert(T newElement, int index) {
		if (index < 0 || index > this->size) {
			throw IndexOutOfRangeException(index, "Incorrect Index in Insert!");
		}

		ListNode<T>* newNode = new ListNode<T>(newElement);

		// first
		if (this->size == 0) {
			this->head = newNode;
			this->tail = newNode;
		}
		else if (index == 0) {
			newNode->next = this->head;
			this->head = newNode;
		}
		//last
		/*else if (index == this->size) {
			this->tail->next = newNode;
			this->tail = newNode;
		}*/
		// middle
		else {
			ListNode<T>* cursor = this->head;

			for (size_t i = 0; i < index - 1; i++)
			{
				cursor = cursor->next;
			}
			
			newNode->next = cursor->next->next;
			cursor->next = newNode; 
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