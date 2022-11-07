#pragma once

#include <iostream>
#include "Colors.h"

using namespace std;



class Animal {
	string name;
	double weight;
	int age = 0;
	bool isAlive = true;

public:
	Animal()
	{
		//cout << "Parameterless Animal constructor" << endl;
	}

	Animal(string name, double weight) : Animal() {
		//cout << "Parametrized Animal constructor" << endl;
		this->SetName(name);
		this->SetWeight(weight);
	}


	void SetName(string name) {
		this->name = name;
	}
	string GetName() {
		return this->name;
	}

	void SetAge(int age) {
		this->age = age;
	}
	int GetAge() {
		return this->age;
	}

	void SetWeight(double weight) {
		this->weight = weight;
	}
	double GetWeight() {
		return this->weight;
	}

	void SetIsAlive(bool isAlive) {
		this->isAlive = isAlive;
	}
	bool GetIsAlive() {
		return this->isAlive;
	}



	void ShowInfo() {
		cout << "Name: '" << this->GetName() << "'" << endl;
		cout << "Age: " << this->GetAge() << " years" << endl;
		cout << "Weight: " << this->GetWeight() << " kg." << endl;
		cout << "IsAlive: " << (this->GetIsAlive() ? "Yes" : "No") << endl;
	}
};




class Cat : public Animal {
public:
	COLORS color = COLORS::White;

	Cat(string name, double weight) : Animal(name, weight)
	{
		//cout << "Cat constructor" << endl;
	}

	void ShowDetailedInfo() {
		this->ShowInfo();
		cout << "Color: " << this->color << endl;
	}

	void SayMeow() {
		cout << this->GetName() << " says: 'Meow'" << endl;
	}
};



class Dog : public Animal {
public:
	bool isTrained = false;

	Dog(string name, double weight, bool isAlive = true) : Animal(name, weight)
	{
		this->SetIsAlive(isAlive);
	}

	void Huf() {
		cout << this->GetName() << " says: 'huf'" << endl;
	}
};



class Parrot : public Animal {
	bool isTalking;

public:

	Parrot(string name, double weight, bool isTalking = false) : Animal(name, weight)
	{
		this->SetIsTalking(isTalking);
	}

	void SetIsTalking(bool isTalking) {
		this->isTalking = isTalking;
	}
	bool GetIsTalking() {
		return this->isTalking;
	}
};



class Turtle : public Animal {
public:
	bool isNinja = false;
};