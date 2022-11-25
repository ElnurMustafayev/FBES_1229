#pragma once

#include <iostream>

using namespace std;

template<typename T>
struct TreeNode {
	TreeNode<T>* right = nullptr;
	TreeNode<T>* left = nullptr;
	TreeNode<T>* parent = nullptr;
	T data;

	TreeNode(T data) : data(data) {}
};

template<typename T>
class BinaryTree {
	TreeNode<T>* root = nullptr;

public:
	TreeNode<T>* getRoot() {
		return this->root;
	}


	TreeNode<T>* search(T data) {
		/*if (this->root == nullptr)
			return nullptr;*/

		TreeNode<T>* cursor = this->root;

		while (cursor != nullptr) {
			if (data == cursor->data)
				return cursor;
			else if (data > cursor->data)
				cursor = cursor->right;
			else if (data < cursor->data)
				cursor = cursor->left;
		}

		return nullptr;
	}


	TreeNode<T>* insert(T data) {
		TreeNode<T>* newNode = new TreeNode<T>(data);

		if (this->root == nullptr) {
			this->root = newNode;
			return this->root;
		}

		TreeNode<T>* cursor = this->root;

		while (true) {
			if (data == cursor->data)
				return cursor;

			else if (data > cursor->data) {
				if (cursor->right == nullptr) {
					newNode->parent = cursor;
					cursor->right = newNode;
					return newNode;
				}

				cursor = cursor->right;
			}

			else if (data < cursor->data) {
				if (cursor->left == nullptr) {
					newNode->parent = cursor;
					cursor->left = newNode;
					return newNode;
				}

				cursor = cursor->left;
			}
		}
	}


	TreeNode<T>* max(TreeNode<T>* head) {
		if (head == nullptr)
			return -1;

		TreeNode<T>* cursor = head;
		while (cursor->right != nullptr) {
			cursor = cursor->right;
		}

		return cursor;
	}


	TreeNode<T>* min(TreeNode<T>* head) {
		if (head == nullptr)
			return nullptr;

		TreeNode<T>* cursor = head;
		while (cursor->left != nullptr) {
			cursor = cursor->left;
		}

		return cursor;
	}


	void show(TreeNode<T>* current) {
		if (current == nullptr)
			return;

		show(current->left);
		cout << current->data << endl;
		show(current->right);
	}


	void remove(T data) {
		TreeNode<T>* found = this->search(data);

		if (found == nullptr)
			return;

		// right and left are null
		if (found->left == nullptr && found->right == nullptr) {
			if (found->data > found->parent->data)
				found->parent->right = nullptr;
			else
				found->parent->left = nullptr;

			delete found;
		}

		// right or left is null
		else if (found->left == nullptr || found->right == nullptr) {
			// is current right
			if (found->data > found->parent->data) {
				// child is right
				if (found->right != nullptr) {
					found->parent->right = found->right;
				}
				// child is left
				else {
					found->parent->right = found->left;
				}
			}
			else {
				// child is right
				if (found->right != nullptr) {
					found->parent->left = found->right;
				}
				// child is left
				else {
					found->parent->left = found->left;
				}
			}

			delete found;
		}
		else {
			TreeNode<T>* toReplace = this->min(found->right);

			swap(found->data, toReplace->data);

			remove(toReplace);

			/*if (toReplace->data > toReplace->parent->data)
				toReplace->parent->right = nullptr;
			else
				toReplace->parent->left = nullptr;

			delete toReplace;*/
		}
	}


private:
	void remove(TreeNode<T>* node) {

		if (node == nullptr)
			return;

		// right and left are null
		if (node->left == nullptr && node->right == nullptr) {
			if (node->data > node->parent->data)
				node->parent->right = nullptr;
			else
				node->parent->left = nullptr;

			delete node;
		}

		// right or left is null
		else if (node->left == nullptr || node->right == nullptr) {
			// is current right
			if (node->data > node->parent->data) {
				// child is right
				if (node->right != nullptr) {
					node->parent->right = node->right;
				}
				// child is left
				else {
					node->parent->right = node->left;
				}
			}
			else {
				// child is right
				if (node->right != nullptr) {
					node->parent->left = node->right;
				}
				// child is left
				else {
					node->parent->left = node->left;
				}
			}

			delete node;
		}
	}
};