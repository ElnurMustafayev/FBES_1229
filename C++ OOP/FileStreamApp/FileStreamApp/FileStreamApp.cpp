#include <iostream>
#include <fstream>

using namespace std;


template<typename T>
void Func(T data, ofstream& fileStream) {
	fileStream << data << endl;
}

template<typename T>
void Func(T data, string filename) {
	ofstream outFileStream = ofstream(filename, std::ofstream::app);
	outFileStream << data << endl;
}



class Person {
public:
	string name;
	string surname;
	int age;

	Person(string name, string surname, int age) : name(name), surname(surname), age(age) {

	}
};


ofstream& operator << (ofstream& stream, Person person) {
	stream << "Name: " << person.name << endl;
	stream << "Surname: " << person.surname << endl;
	stream << "Age: " << person.age << endl;

	return stream;
}


int main()
{
	/*
	int num;

	cin >> num;

	cin.ignore();
	string str;
	cin >> str;

	cout << num << endl;
	cout << str << endl;
	*/



	ifstream inputFileStream = ifstream("primitives.txt");

	string data;
	inputFileStream >> data;
	inputFileStream >> data;
	inputFileStream >> data;

	cout << data << endl;





	/*Person p = Person("Bob", "Black", 20);
	ofstream outFileStream1 = ofstream("person.txt");
	ofstream outFileStream2 = ofstream("person.txt");
	outFileStream1 << p << "1";
	outFileStream2 << p << "2";*/



	//Func(1231231, "qwerty.txt");

	//ofstream outFileStream = ofstream("data.txt", std::ofstream::app);
	//Func("test data", outFileStream);

	/*
	ofstream outFileStream = ofstream("primitives.txt");

	outFileStream << "Hello " << endl << "World!";
	outFileStream << 1231 << endl << 4534.46346 << endl << true << endl << 123 + 35 << endl;

	int num = 12312;
	outFileStream << &num << endl;
	*/
}