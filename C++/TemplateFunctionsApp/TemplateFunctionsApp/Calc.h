#pragma once
using namespace std;


template<typename T>
T Sum(T num1, T num2) {
	return num1 + num2;
}

template<typename T>
T Pow(T num, int power) {
	if (power == 0)
		return 1;

	T result = 1;

	for (int i = 0; i < power; i++)
		result *= num;

	return result;
}

template<typename T>
void Func(T arg) {
	cout << sizeof(arg) << endl;
}



template<typename T1, typename T2, typename T3>
T3 Minus(T1 num1, T2 num2) {
	return num1 - num2;
}











//int Sum(int num1, int num2) {
//	return num1 + num2;
//}
//
//float Sum(float num1, float num2) {
//	return num1 + num2;
//}
//
//double Sum(double num1, double num2) {
//	return num1 + num2;
//}