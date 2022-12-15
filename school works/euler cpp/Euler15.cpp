/*
Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.


How many such routes are there through a 20×20 grid?

The hard part here is the math, i think i did it correctly but honestly its kind of hard for me to check
*/
#include <iostream>

using namespace std;

int main() {
	const int gridSize = 20;
	long paths = 1;

	for (int i = 0; i < gridSize; i++) {
		paths *= (2 * gridSize) - i;
		paths /= i + 1;
	}
	cout << paths;
	system("PAUSE");
	return 0;
}