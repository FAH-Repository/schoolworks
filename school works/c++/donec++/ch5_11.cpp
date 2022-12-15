#include "std_lib_facilities.h"
/*
Forest H.
Write a program that writes out the first so many values of the Fibonacci series, that is, the
series that starts with 1 1 2 3 5 8 13 21 34. The next number of the series is the sum of the two
previous ones. Find the largest Fibonacci number that fits in an int.

*/


int main()
try
{
	int n = 1;
	int m = 2;

	while (n<m) {
		cout << n << '\n';
		int x = n + m;
		n = m;	// drop the lowest number
		m = x;	// add a new highest number
	}

	cout << "the largest Fibonacci number that fits in an int is " << n << '\n';

	system("PAUSE");	
}
catch (runtime_error e) {	// error messages
	cout << e.what() << '\n';
	system("PAUSE");	
}