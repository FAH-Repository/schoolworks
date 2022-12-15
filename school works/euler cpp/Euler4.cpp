// this project asks you to find the lagest palindrome of the product of two, three didgit numbers. tested some numbers and some lower loop values
#include<iostream>
using namespace std;
bool palindrome(int num) {
	int rev = 0, val;
	val = num;
	while (num > 0) {
		rev = rev * 10 + num % 10;
		num = num / 10;
	}
	if (val == rev) {
		//cout << val << " is a palindrome" << endl;
		return true;
	}
	else {
		//cout << val << " is not a palindrome" << endl;
		return false;
	}
	 
}
int main() {
	int cur;
	int hold=0;
	for (int i = 100; i < 1000; i++) {

		for (int k = 100; k < 1000; k++) {
			cur = k * i;
			if (palindrome(cur) == true) {
				if (cur > hold) {
					hold = cur;
				}
			}
			
		}
	}

	//palindrome(12321);
	//palindrome(1234);
	cout << hold;
	system("pause");
	return 0;
	
}