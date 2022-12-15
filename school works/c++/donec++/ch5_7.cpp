#include "std_lib_facilities.h"
/*
Forest H
Quadratic equations are of the form
a · x2 + b · x + c = 0
To solve these, one uses the quadratic formula:
There is a problem, though: if b2–4ac is less than zero, then it will fail. Write a program that
can calculate x for a quadratic equation. Create a function that prints out the roots of a quadratic
equation, given a, b, c. When the program detects an equation with no real roots, have it print
out a message. How do you know that your results are plausible? Can you check that they are
correct?



*/


double* roots(double a, double b, double c) {
	double *result = new double[2];
	double sqrtVal = sqrt(b*b-4*a*c);
	result[0] = (-b + sqrtVal)/(2*a);
	result[1] = (-b - sqrtVal)/(2*a);
	return result;
}

bool check(double a, double b, double c, double root, double root2) {
	double val = a * root*root + b * root + c;
	double val2 = a * root2*root2 + b * root2 + c;	
	const double zero = .0000000001;

	cout << "Root1 gives: " << val << endl;
	cout << "Root2 gives: " << val2 << endl;

	if (val < zero && val2 < zero) {
		return true;
	}
	else {
	return false;
	}

}

int main() {
	double a, b, c;
	double *result2;

	cout << "Give three double or int inputs a,b,c: " << endl;
	cin >> a;
	cin >> b;
	cin >> c;


	if (a == 0) {
	cout << "Dividing by 0" << endl;
	}
	if (b*b - 4 * a*c < 0) {
		cout << "No square root" << endl;
	}
	result2 = roots(a,b,c);

	cout << "The roots: " << result2[0] << " , " << result2[1] << endl;

	if (check(a, b, c, result2[0], result2[1])) {
		cout << "Roots are correct" << endl;
	}
	else {
		cout << "Roots are incorrect" << endl;
	}
	delete result2;
	system("Pause");
}

