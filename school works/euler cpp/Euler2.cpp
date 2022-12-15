#include < iostream>

using namespace std;
/*
within 4,000,000 find the sum of even valued terms in the fibonacci sequence, tested it with first 10 digits, it correctly yielded 44
*/
int main() {
	int start = 1;
	int second = 2;
	double total = 0;
	int counter = 2;
	int buffer = 0;
	
	while (counter < 4000000) {
		buffer = start + second;
		start = second;
		second = buffer;
		if (buffer % 2 == 0) {
			total += buffer;
		}
		counter++;
	}
	total += 2; //because i start with 1 and 2 i wasnt including 2 in the total, so I just add it here
	cout << total << endl;

	system("pause");
}
