#include <iostream>
#include "Classes.h"

using namespace std;

int main()
{
	D d = D();
	cout << d.C::num << endl;
	cout << d.B::num << endl;

	/*Three t = Three();

	t.One::Func();
	t.Two::Func();*/

	//cout << sizeof(Three) << endl;


	/*B b = B(12, 15);


	// numA1 = 2;
	// numA2 = 15;
	// numB1 = 1;
	// numB2 = 2;

	cout << b.numA1 << endl;
	cout << b.numA2 << endl;

	cout << b.numB1 << endl;
	cout << b.numB2 << endl;*/
}