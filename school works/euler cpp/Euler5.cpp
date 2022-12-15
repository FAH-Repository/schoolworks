#include <iostream>
using namespace std;
/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

used their test case of 2520
then tested some small loops, had to reset i for it to work
*/

int main() {
	
	int num = 1;
	bool works = false;
	
	for (int i = 1; i < 21; i++) {
		if (num % i == 0) {
			works = true;
			//cout << i;
		}
		else {
			works = false;
			num++;
			i = 0;
		}
	}
	if (works == true) {
		cout << num  <<" Works!";
	}
	else {
		cout << num << " wont work";
	}
	
	system("pause");
}