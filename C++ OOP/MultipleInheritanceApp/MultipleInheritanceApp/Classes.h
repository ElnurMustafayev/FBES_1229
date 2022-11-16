#pragma once

#include <iostream>

using namespace std;



// DIAMOND PROBLEM
class A {
public:
	int num = 0;
};

class B : public A {
public:
	B() {
		this->num = 1;
	}
};

class C : public A {
public:
	C()
	{
		this->num = 2;
	}
};

class D : public B, public C {
	int num = 123123;
public:
	D()
	{
		this->num = 123;
		cout << this->B::num << endl;
		//cout << this->C::num << endl;
	}
};




//class One {
//public:
//	int num = 0;
//	int num1 = 6;
//
//	void Func() {
//		cout << "Func from One!" << endl;
//	}
//};
//
//class Two {
//public:
//	int num = 78;
//	int num2 = 235;
//
//	void Func() {
//		cout << "Func from Two!" << endl;
//	}
//};
//
//
//
//class Three : public One, public Two {
//public:
//
//	Three()
//	{
//		this->num1 = 123;
//		this->num2 = 321;
//
//		this->Two::num = 777;
//		this->One::num = 111;
//
//		this->Two::Func();
//		this->One::Func();
//	}
//};
















//int Func(char symbol) {
//	cout << "FUNC: " << symbol << endl;
//	return symbol;
//}




//class A {
//public:
//	int numA1 = Func('a');
//	int numA2 = Func('A');
//
//	A()
//	{
//		cout << "CTOR A" << endl;
//	}
//};
//
//class B : public A {
//public:
//	int numB1 = Func('b');
//	int numB2 = Func('B');
//
//	B()
//	{
//		cout << "CTOR B" << endl;
//	}
//};






//class A {
//public:
//	int numA1 = 1;
//	int numA2 = 2;
//
//	A(int num1, int num2) {
//		this->numA1 = this->numA2;
//		this->numA2 = num2;
//	}
//};
//
//class B : public A {
//public:
//	int numB1 = 1;
//	int numB2 = 2;
//
//	B(int num1, int num2) : A(num1, num2) {
//		this->numB2 = this->numA1;
//	}
//};










//class ThrowWeapon {
//
//};
//
//class ShootWeapon {
//
//};
//
//class ShootThrowWeapon : ThrowWeapon, ShootWeapon {
//
//};