#pragma once
#include <iostream>

using namespace std;

class Hero {
public:
	char* name = {};
	int attack = 10;
	int defence = 10;
	int hp = 100;

	Hero(int attack = 10, 
		int defence = 10, 
		int hp = 100, 
		char* name = nullptr) {

		this->attack = attack;
		this->defence = defence;
		this->hp = hp;
		this->name = name;
	}

	void Attack(Hero& enemy) {
		int damage = this->attack - enemy.defence;

		if (damage > 0) {
			cout << this->name << " damaged " << enemy.name << " " << damage << " damage..." << endl;
			enemy.hp -= damage;
		}
	}


	void ShowHp() const {
		cout << this->name << ": " << this->hp << endl;
	}
};