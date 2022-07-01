#include <iostream>

using namespace std;

int main()
{
	/*
	for (int i = 0; i < 10; i++)
	{
		if(i % 2 == 0)
			cout << i << endl;

		if (i % 2)
			continue;

		cout << i << endl;
	}
	*/
	

	/*
	int numberToGuess = 123;
	int number;
	int attemptCount = 5;
	int attempt = 1;
	bool success = false;

	for (; attempt <= attemptCount && !success; attempt++)
	{
		cin >> number;

		if (number == numberToGuess) {
			cout << "Success! You win for " << attempt << " steps" << endl;
			success = true;
		}
	}

	if (success == false) {
		cout << "you lose for " << attemptCount << " steps" << endl;
	}
	*/

	/*
	int number;
	cin >> number;

	for (int x = 1; x <= 5; x++)
	{
		for (int y = 0; y < x; y++)
		{
			cout << "*";
		}
		cout << endl;
	}
	*/
	


	/*
	int range;
	cin >> range;

	for (int a = 1; a <= range; a++)
	{
		for (int b = 1; b <= range; b++)
		{
			cout << a << " * " << b << " = " << a * b << endl;
		}
		cout << endl;
	}
	*/
	


	//cout << (false ? "yes" : "no") << endl;

	/*
	int num1;
	int num2;

	cin >> num1;
	cin >> num2;

	char resultSymbol = num1 >= num2 ? '+' : '-';

	//char resultSymbol;
	//
	//if (num1 > num2)
	//	resultSymbol = '+';
	//else
	//	resultSymbol = '-';
	

	cout << resultSymbol << endl;
	*/

	//cout << (char)(false ? 'a' : 42) << endl;

	//char i = (true ? 'a' : 123);
	//cout << i << endl;





	//int age;

    //cin >> age;

    //bool isAdult = (age >= 18); // ? true : false;

    //cout << isAdult << endl;




    /*
    for (int x = 0; x < 10; x++)
    {
        for (int y = 0; y < 10; y++)
        {
            cout << x << " * " << y << " = " << x * y << endl;
        }
        cout << endl;
    }
    */


    /*
    for (int x = 0, y = 0; x < 100; x++)
    {
        y += (x % 10 == 0);

        cout << y << " * " << x % 10 << " = " << (x % 10) * y << endl;
    }
    */
    


    /*
    for (int x = 0, y = 0; y < 10; x++)
    {
        if (x == 10) {
            x = 0;
            cout << endl;

            if (++y == 10)
                break;
        }

        cout << y << " * " << x << " = " << x * y << endl;
    }
    */
}