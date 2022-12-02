#pragma once

namespace comp {
	enum BLOOD_GROUPS {
		one_plus,
		one_minus,

		two_plus,
		two_minus,

		three_plus,
		three_minus,

		four_plus,
		four_minus,

		unknown,
	};


	enum BLOOD_COLORS {
		red,
		green,
		blue
	};




	class Heart {
		int heartBeating;
		int avgHeartBeating;

	public:
		Heart() {}

		Heart(int heartBeating) {
			this->heartBeating = heartBeating;
			this->avgHeartBeating = heartBeating;
		}
	};

	class Blood {
		BLOOD_GROUPS group;
		BLOOD_COLORS color;

	public:
		Blood(BLOOD_GROUPS group = BLOOD_GROUPS::unknown, BLOOD_COLORS color = BLOOD_COLORS::red) {
			this->group = group;
			this->color = color;
		}
	};


	class Person {
	public:
		Heart heart;
		Blood blood;

		Person(int heartBeating, BLOOD_GROUPS group = BLOOD_GROUPS::unknown)
		{
			heart = Heart(heartBeating);
			blood = Blood(group);
		}
	};
}