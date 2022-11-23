#pragma once

template<typename T>
struct TreeNode {
	TreeNode<T>* right = nullptr;
	TreeNode<T>* left = nullptr;
	TreeNode<T>* parent = nullptr;
	T data;
};

template<typename T>
class BinaryTree {
	TreeNode<T>* root = nullptr;

public:
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



	void insert(T data) {
		// ...

		// 7,25,3,17,5,26,24,0,2
	}
};