#pragma once

#include <iostream>
#include<map>
#include<vector>

using namespace std;



template<class T>
class HashSet {
	map<int, vector<T>> table;
	const int separator;

public:
	HashSet(int separator) : separator(separator)
	{
		this->table = map<int, vector<T>>();
	}

	void Add(T data) {
		int hash = this->GetHash(data);

		table[hash].push_back(data);
	}



	T Get(T data) {
		int hash = this->GetHash(data);

		auto row = table[hash];

		for (auto item : row)
			if (item == data)
				return data;
	}



	int GetHash(T data) {
		return data % separator;
	}

	void Show() {
		for (pair<int, vector<T>> p : table)
		{
			cout << p.first << ": " << endl;
			for (auto v : p.second) {
				cout << "> " << v << endl;
			}
		}
	}
};