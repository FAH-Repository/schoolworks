/*
The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

*/

#include <iostream>
#include <vector>
#include <map>

using namespace std;


int main() {

	const int number = 1000000;

	unsigned long sequenceLength = 0;
	unsigned long startingNumber = 0;
	unsigned long sequence;


	for (int i = 2; i <= number; i++) {
		int length = 1;
		sequence = i;
		while (sequence != 1) {
			if ((sequence % 2) == 0) {
				sequence = sequence / 2;
			}
			else {
				sequence = sequence * 3 + 1;
			}
			length++;
		}

		//Check if sequence is the best solution
		if (length > sequenceLength) {
			sequenceLength = length;
			startingNumber = i;
		}
	}
	
	cout << startingNumber;
	cout << "\nsequence length of \n";
	cout << sequenceLength;

	system("PAUSE");
	return 0;
}