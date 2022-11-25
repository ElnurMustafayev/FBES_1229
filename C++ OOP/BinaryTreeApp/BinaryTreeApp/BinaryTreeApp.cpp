#include <iostream>
#include "BinaryTree.h"

using namespace std;

int main()
{
	BinaryTree<int> tree = BinaryTree<int>();

	int arr[] = { 50, 77, 34, 56, 60, 76, 25, 79, 53, 71, 94, 35, 58 };

	for (auto item : arr) {
		tree.insert(item);
	}

	tree.remove(56);

	tree.show(tree.getRoot());

	
	/*auto root = tree.insert(10);
	tree.insert(20);
	tree.insert(30);

	tree.insert(5);
	tree.insert(0);

	tree.remove(20);

	tree.show(root);*/
}