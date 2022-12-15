#include "std_lib_facilities.h"
/*
Forest H.
Modify the program from exercise 8 to use double instead of int. Also, make a vector of
doubles containing the N–1 differences between adjacent values and write out that vector of
differences.

 prob 8 was:
 Write a program that reads and stores a series of integers and then computes the sum of the first
 N integers. First ask for N, then read the values into a vector, then calculate the sum of the first
 N values. For example:
 “Please enter the number of values you want to sum:”
 3
 “Please enter some integers (press '|' to stop):”
 12 23 13 24 15 |
 “The sum of the first 3 numbers ( 12 23 13 ) is 48.”
 Handle all inputs. For example, make sure to give an error message if the user asks for a sum of
 more numbers than there are in the vector.
*/




double sumNums( vector<double> &nums, int N) {
	cout << "sumNums: " << endl;
	double sum = 0;
	for (int i=0; i<N; i++) 
		sum+= nums[i];
	return sum;
}

void prNums(vector<double> & nums, const string &s) {
	cout << s << endl;
	for (int i = 0; i<nums.size(); i++)
		cout << nums[i] << ", ";
	cout << endl;
} 

void diffs( vector<double> & nums,  vector<double> & diffVector) {
	cout << "In diffs" << endl;
	for (int i=0; i<nums.size()-1; i++) 
		diffVector.push_back(nums[i]-nums[i+1]);
}

void inp(vector<double> & numbers) {
	int i=0;
	double n;
	int c;
	cout << "Please enter some doubles, '|' to stop: " ;
	while (true) {
		c = cin.peek() ;
		switch (c) {
		case EOF:	
		case '|':	return;
		case ' ': case '\t':
		case '\n':	cin >> ws;	// ws in std
				break; // ignore newlines and whitespace
		case '0': case '1': case '2': case '3': case '4': 
		case '5': case '6': case '7': case '8': case '9': case '.':
				cin >> n;
				numbers.push_back(n);
				break;
		default:	error("Incorrect input");
		}
	}
	return;
}


int main() {
	vector<double> nums;
	vector<double> diffV;
	int n;

	cout << "Number of values to sum: " ;
	cin >> n;
	inp(nums);
	cout << "Size of nums: " << nums.size() << endl;
	prNums(nums, "Here are the nums");
	if (nums.size() < n) {
		cerr << "Too few numbers entered." << endl;
		system("PAUSE");
		
	}
	cout << "Sum: " << sumNums(nums, n) << endl;

	diffs(nums, diffV);
	prNums(diffV, "Here are the diffs:");
	system("PAUSE");
}


