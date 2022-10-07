#pragma once
#include <iostream>

using namespace std;

class Calc {
public:
	int x;
	int y;

	int Sum() {
		return this->x + this->y;
	}
	int Minus() {
		return x - y;
	}
	int Mult() {
		return this->x * this->y;
	}
	int Div() {
		return x / y;
	}
};