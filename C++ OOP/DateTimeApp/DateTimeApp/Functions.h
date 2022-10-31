#pragma once

#include <vector>

using namespace std;

template<typename T>
bool Contains(vector<T> arr, T elementToFind) {
	for (int i = 0; i < arr.size(); i++)
		if (arr[i] == elementToFind)
			return true;
	return false;
}