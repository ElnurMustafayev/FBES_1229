#pragma once

#include <iostream>

using namespace std;

class Hero {
	string name;
	double attack;
	double defence;
	double hp = 100;
	double xray = 0;
	bool isAlive = true;

public:
	// CTORS
	Hero(string name, double attack, double defence);







	// NAME
	void SetName(string name);
	string GetName() const;

	// ATTACK
	void SetAttack(double attack);
	double GetAttack() const;

	// DEFENCE
	void SetDefence(double defence);
	double GetDefence() const;

	// HP
	void SetHp(double hp);
	double GetHp() const;

	// XRAY
	void SetXray(double xray);
	double GetXray() const;

	// ISALIVE
	void SetIsAlive(bool isAlive);
	bool GetIsAlive() const;






	// OPERATORS
	void operator -= (double damage);

	Hero& operator - (Hero& enemy);
};