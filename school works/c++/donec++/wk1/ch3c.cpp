#include < iostream>
#include <string>
using namespace std;

int main() {
	string operation;
	int answer;
	double a, b;
	cout << "give an operator (+,-,*,/) and two numbers: \n";
	//getline(cin, operation, a, b);
	
	cin >> operation >> a >>b;
	//cin >> b;
	
	if (operation == "+" || operation == "plus") {
		answer = a + b;
		cout << answer << "\n";
	}
	else if (operation == "-" || operation == "minus") {
		answer = a - b;
		cout << answer << "\n";
	}
	else if (operation == "*" || operation == "mul") {
		answer = a * b;
		cout << answer << "\n";
	}
	else if (operation == "/" || operation == "div") {
		answer = a / b;
		cout << answer << "\n";
	}
	else {
		cout << "Im not designed to handle this :(\n";
	}
	

	system("pause");
}