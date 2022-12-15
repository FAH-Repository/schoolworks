#include "std_lib_facilities.h"
/*
Forest H.
Write a program that reads digits and composes them into integers. For example, 123 is read as
the characters 1, 2, and 3. The program should output 123 is 1 hundred and 2 tens and 3
ones. The number should be output as an int value. Handle numbers with one, two, three, or
four digits. Hint: To get the integer value 5 from the character '5' subtract '0', that is,
'5'–'0'==5.

Re-did how you did because mine was long, at bottom is mine
*/
int decode(char c ) {
	return c - '0';
}

string position (int val, int pos) {
	string result;
	switch (pos) {
	case 0:	result =  "one";
			break;
	case 1: result =  "ten";
			break;
	case 2: result =  "hundred";
			break;
	case 3: result =  "thousand";
			break;
	default: result =  "too big";
			break;
	}

	if (val != 1)
		result += "s";

	return result;

}

int main() {
	string number;
	int pos;

	cin >> number ;
	pos = number.size()-1;

	for (int i =0; i<number.size();  i++) {
		int val = decode(number[i]);
		cout << val << " " << position(val, pos--) << " ";
	}
	cout << endl;
}
/*

int main()
try
{
vector<int> digit;	
vector<string> unit;	
unit.push_back(" ones ");
unit.push_back(" tens ");
unit.push_back(" hundreds ");;
unit.push_back(" thousands ");
unit.push_back(" tens of thousands ");
unit.push_back(" hundreds of thousands ");
unit.push_back(" millions ");
unit.push_back(" tens of millions ");
unit.push_back(" hundreds of millions ");

/*
The exercise didn't specify how to terminate a number, so I decided.
*/
/*
cout << "Please enter an integer with no more than " << unit.size()
<< "\ndigits followed by semicolon and a newline: ";
char ch;
while (cin >> ch) {					
	if (ch<'0' || '9'<ch) break;	
	digit.push_back(ch - '0');
}

if (digit.size() == 0) error("no digits");
if (unit.size()<digit.size()) error("Sorry, cannot handle that many digits");

// write out the number:
for (int i = 0; i<digit.size(); ++i)
	cout << char('0' + digit[i]);
cout << '\n';


int num = 0;
for (int i = 0; i<digit.size(); ++i) {
	if (digit[i])	// don't mention a unit if its count is zero
		cout << digit[i] << unit[digit.size() - i - 1];
	num = num * 10 + digit[i];
}
cout << "\nthat is " << num << '\n';

system("PAUSE")
}
catch (runtime_error e) {	// error code
	cout << e.what() << '\n';
	system("PAUSE")	
}



*/