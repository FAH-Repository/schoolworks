/*
Forest H.

A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/

#include <iostream>

using namespace std;

int main() {
	int a = 0, b = 0, c = 0;
	int s = 1000;
	int ans;
	bool found = false;
	for (a = 1; a < s / 3; a++) {
		for (b = a; b < s / 2; b++) {
			c = s - a - b;//shortcut to find c rather than another loop
			if (a * a + b * b == c * c) {//check its correct jsut in case
				found = true;
				break;
			}
		}

		if (found) {
			ans = a * b*c;
			break;
		}
	}
	cout << "a, b, c, product" << endl;
	cout << a << endl;
	cout << b << endl;
		cout << c << endl;
		cout << ans << endl;
	system("pause");
}