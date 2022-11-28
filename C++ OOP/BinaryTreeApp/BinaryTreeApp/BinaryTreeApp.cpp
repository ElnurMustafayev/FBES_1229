#include <iostream>
#include <map>
#include <set>
#include "BinaryTree.h"

using namespace std;

struct Person {
	string name;
	string surname;
	int age;
	string FIN;

	Person(string name, string surname, int age, string FIN) : age(age), surname(surname), name(name), FIN(FIN)
	{

	}

	Person() {

	}
};

int main()
{
	/*BinaryTree<int> tree = BinaryTree<int>();

	int arr[] = { 50, 77, 34, 56, 60, 76, 25, 79, 53, 71, 94, 35, 58 };

	for (auto item : arr) {
		tree.insert(item);
	}

	tree.remove(56);

	tree.show(tree.getRoot());*/

	
	/*auto root = tree.insert(10);
	tree.insert(20);
	tree.insert(30);

	tree.insert(5);
	tree.insert(0);

	tree.remove(20);

	tree.show(root);*/


	// SET
	/*set<string> collection = set<string>();

	collection.insert("124122");
	collection.insert("qweqex");
	collection.insert("aaaasx");
	collection.insert("aadzxc");
	collection.insert("fgsdss");

	for (string item : collection)
	{
		cout << item << endl;
	}*/

	// MAP

	// FIN, PERSON
	map<string, Person> peopleMap = map<string, Person>();

	Person people[] = {
		Person("Bob", "Bobovich", 123, "QWQWETY"),
		Person("Ann", "Test", 42, "125YTSD"),
		Person("Wolter", "Brown", 35, "AZAGDAS"),
	};

	for (Person person : people) {
		// set
		peopleMap[person.FIN] = person;
	}

	// get
	cout << peopleMap["QWQWETY"].name << endl;

	// indexers
	/*
	peopleMap[p1.FIN] = p1;
	peopleMap[p2.FIN] = p2;
	peopleMap[p3.FIN] = p3;
	*/


	// pairs
	/*
	pair<string, Person> pairToAdd1 = pair<string, Person>(p1.name, p1);
	pair<string, Person> pairToAdd2 = pair<string, Person>(p2.name, p2);
	pair<string, Person> pairToAdd3 = pair<string, Person>(p3.name, p3);

	peopleMap.insert(pairToAdd1);
	peopleMap.insert(pairToAdd2);
	peopleMap.insert(pairToAdd3);
	*/

	/*for (pair<string, Person> pair : peopleMap) {
		cout << "FIN: " << pair.first << endl;
		cout << "Name: " << pair.second.name << endl;
	}*/
}