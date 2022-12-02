#pragma once

#include <iostream>
#include <vector>

using namespace std;

namespace agr {

	class Person {
	public:
		string name;
		string surname;

		vector<Person>* childer;

		Person(string name, string surname) : name(name), surname(surname) {}
	};

	class Family {
	public:
		Person* wife;
		Person* husband;

		vector<Person>* childer;

		void SetChildren(vector<Person>* childer)
		{
			this->childer = childer;
			this->wife->childer = childer;
			this->husband->childer = childer;
		}

		void KillLastChild() {
			if (childer == nullptr)
				return;

			childer->pop_back();
		}
	};
}