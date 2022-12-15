#include <iostream>
#include <chrono>

int main() {
	int sundays = 0;

	for (int year = 1901; year <= 2000; year++) {
		for (int month = 1; month <= 12; month++) {
			if ((new DateTime(year, month, 1)).DayOfWeek == DayOfWeek.Sunday) {
				sundays++;
			}
		}
	}

	cout << sundays;
	system("Pause");
	return 0;
}