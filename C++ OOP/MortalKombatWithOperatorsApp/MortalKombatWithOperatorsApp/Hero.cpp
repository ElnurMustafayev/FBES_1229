#include "Hero.h"




// - - - - - - - C T O R S - - - - - - - -
Hero::Hero(string name, double attack, double defence)
{
	this->SetName(name);
	this->SetAttack(attack);
	this->SetDefence(defence);
}












// - - - - - - - A C C E S S O R S - - - - - - - -
// NAME
void Hero::SetName(string name) {
	this->name = name;
}
string Hero::GetName() const {
	return this->name;
}

// ATTACK
void Hero::SetAttack(double attack) {
	this->attack = attack;
}
double Hero::GetAttack() const {
	return this->attack;
}

// DEFENCE
void Hero::SetDefence(double defence) {
	this->defence = defence;
}
double Hero::GetDefence() const {
	return this->defence;
}

// HP
void Hero::SetHp(double hp) {
	this->hp = hp < 0 ? 0 : hp;

	if (this->hp <= 0) {
		this->SetIsAlive(false);
	}
}
double Hero::GetHp() const {
	return this->hp;
}

// XRAY
void Hero::SetXray(double xray) {
	this->xray = xray;
}
double Hero::GetXray() const {
	return this->xray;
}

// ISALIVE
void Hero::SetIsAlive(bool isAlive) {
	this->isAlive = isAlive;
}
bool Hero::GetIsAlive() const {
	return this->isAlive;
}










// - - - - - - - O P E R A T O R S - - - - - - - -
void Hero::operator -= (double damage) {
	this->SetHp(this->GetHp() - damage);
}

Hero& Hero::operator - (Hero& enemy) {
	if (this->GetIsAlive() == false || enemy.GetIsAlive() == false)
		return *this;

	double damage = this->attack - enemy.GetDefence();
	damage = damage <= 0 ? 1 : damage;

	enemy -= damage;

	return *this;
}