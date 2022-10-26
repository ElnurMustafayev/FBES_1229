#pragma once
#include <iostream>

namespace cars {
	//using namespace std;

	enum CARS_STATUS {
		broken,
		ok
	};

	class Car {
	public:
		CARS_STATUS status = CARS_STATUS::ok;
		int maxSpeed = 0;
		std::string model = "Unknown";

		Car(int maxSpeed, string model)
		{
			this->model = model;
			this->maxSpeed = maxSpeed;
		}

		void ShowInfo() {
			std::cout << "Model: " << this->model << std::endl;
			std::cout << "Max Speed: " << this->maxSpeed << std::endl;
		}
	};
}