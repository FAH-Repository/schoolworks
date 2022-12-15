#include < iostream>
#include <string>
using namespace std;

int main() {
	int c;
	string inp;
	cout << "hi\n";
	getline(cin, inp);
	if (inp == "zero") {
		cout << 0 << "\n";
	}
	else if (inp == "one") {
		cout << 1 << "\n";

	}

	else if (inp == "two") {
		cout << 2 << "\n";
	}
	else {
		cout << "I dont know that number\n";
	}
	system("pause");
}