#include < iostream>

using namespace std;

int main() {
	int a;
	cout << "enter an integer please:\n";
		cin >> a;


	if (a % 2 ==0) {
		cout << "The value " << a << " is even\n";
	}
	else {
		cout << "The value " << a << " is odd\n";
	}

	system("pause");

}