#include <iostream>
#include <cmath>
using namespace std;
/*
Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

so pow(1)+pow(2)+..pow(10) = num
and pow((1+2+3+..10)) = num2
num2-num = answer

tested with their first ten of each example and it worked
*/

int main() {
	int count = 0;
	int ans = 0;
	int count2 = 0;
	int sol;
	for (int i = 0; i < 101;i++) {
	count += pow(i, 2.0);
	}

	for (int k = 0; k < 101; k++) {
		count2 += k;
	}
	ans = pow(count2, 2.0);
	sol = ans - count;
	cout << sol;

	system("pause");
}