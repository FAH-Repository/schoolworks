#include "std_lib_facilities.h"
/*
Forest H.
Write a function maxv() that returns the largest element of a vector argument.

*/
int maxv(const vector<int> & v) {
	int max = v[0];
	for(int i=0; i<v.size(); i++) 
		if (v[i] > max)
			max = v[i];
	return max;
}

int main() {
	vector<int> vect = {10, 2, 66, 5, 99, 15, 36, 2};
	cout << "The max is: " << maxv(vect) << endl;
}
