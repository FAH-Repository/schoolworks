#include <iostream>
#include <String>
using namespace std;

/*
Forest H.
Do exercise 7 again, but this time read into a std::string rather than to memory you put on the
free store (string knows how to use the free store for you).

*/

string readChars(int sz) {
	string s;
	char c;
	int i=0;
	cout << "Enter chars up to a !" << endl;

	while (cin >> c  && c != '!') {
		s.push_back(c);
		;
	}
	return s;
}

int main() {
	string p = readChars(1024);
	cout << "String: " << p << endl;
}
