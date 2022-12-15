#include < iostream>
#include <string>
using namespace std;
// Im not sure how this differs much from the 10th ch3 problem, just adding some flavortext and polish?
int main() {
	string operation;
	int answer;
	double a, b;
	
	cout << "give your first value\n";

	cin >> a;
	cout << "give your first value\n";
	cin >> b;
	cout << "give an operator (+,-,*,/)\n";
	cin >> operation;

	if (operation == "+" || operation == "plus") {
		answer = a + b;
		cout << "The sum of " << a << " and " << b << " is  "<< answer << "\n";
	}
	else if (operation == "-" || operation == "minus") {
		answer = a - b;
		cout << "The difference between " << a << " and " << b << " is  " << answer << "\n";
	}
	else if (operation == "*" || operation == "mul") {
		answer = a * b;
		cout << "The product " << a << " and " << b << " is  " << answer << "\n";
	}
	else if (operation == "/" || operation == "div") {
		answer = a / b;
		cout << "The divedend of " << a << " and " << b << " is  " << answer << "\n";
	}
	else {
		cout << "Im not designed to handle this :(\n";
	}


	system("pause");
}