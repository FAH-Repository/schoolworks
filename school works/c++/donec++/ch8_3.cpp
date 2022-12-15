#include "std_lib_facilities.h"
/*
Forest H.
Create a vector of Fibonacci numbers and print them using the function from exercise 2. To
create the vector, write a function, fibonacci(x,y,v,n), where integers x and y are ints, v is
an empty vector<int>, and n is the number of elements to put into v; v[0] will be x and v[1]
will be y. A Fibonacci number is one that is part of a sequence where each element is the sum
of the two previous ones. For example, starting with 1 and 2, we get 1, 2, 3, 5, 8, 13, 21, . . . .
Your fibonacci() function should make such a sequence starting with its x and y arguments.

ended up copying cause mine wasnt working for this one :/ could count this one as not submitted if you want
*/

void print(const string & label, const vector<int> &v) {
	cout << label << " of size " <<v.size() << endl;
	for (const int &i : v)
		cout << i << ", " ;

	cout << endl;
}

void innerFib(vector<int>& v, int current, int n) {
	if (current == n)
		return;
	else {
		v[current] = v[current-1] + v[current-2];
		innerFib(v, current+1, n);
	}
}


void fibs(int x, int y, vector<int> & v, int n) {
	v[0] = x;
	v[1] = y;
	innerFib(v, 2, n);
	print("Here are my fibs", v);
}

int main() {
	vector<int> myfibs(25) ;
	fibs(1,1, myfibs, 25);

}
