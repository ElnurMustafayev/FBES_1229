#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <cstring>

using namespace std;

//void Register() {
//    char name[30];
//    cout << "Name: ";
//    cin >> name;
//
//    char surname[30];
//    cout << "Surname: ";
//    cin >> surname;
//
//    int userInput;
//    cout << "Gender (input '1' to male): ";
//    cin >> userInput;
//    bool isMale = userInput == 1;
//
//
//
//    system("cls");
//    
//    const char* genderRefere = isMale ? "Mr" : "Mrs";
//
//    cout << genderRefere << endl;
//}



enum NOTIFICATION_STATUSES {
	success,
	info,
	warning,
	error
};



void PrintNotification(const char* message, NOTIFICATION_STATUSES status) {

	if (status == NOTIFICATION_STATUSES::success)
		cout << "Coungratulations!!!" << endl;

	switch (status)
	{
		case NOTIFICATION_STATUSES::success:
			cout << "Success: " << message << endl;
			break;
		case NOTIFICATION_STATUSES::info:
			cout << "Info: " << message << endl;
			break;
		case NOTIFICATION_STATUSES::warning:
			cout << "Warning: " << message << endl;
			break;
		case NOTIFICATION_STATUSES::error:
			cout << "Error: " << message << endl;
			break;
		default:
			break;
	}
}



int main()
{
    //Register();

	PrintNotification("User logined", NOTIFICATION_STATUSES::success);
	PrintNotification("User not found", NOTIFICATION_STATUSES::error);
}
