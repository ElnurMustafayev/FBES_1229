#pragma once

class Exception {
public:
	const char* Message;
	bool Success;
	short Code;

	Exception(const char* message, short code = -1, bool success = false) {
		this->Message = message;
		this->Code = code;
		this->Success = success;
	}

	void ShowError() {
		cout << "Message: " << this->Message << endl;
		cout << "Code: " << this->Code << endl;
		cout << "Success: " << this->Success << endl;
	}
};