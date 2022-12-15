#include "std_lib_facilities.h"

/*

*/

double* roots(double a, double b, double c) {
	double *result = new double[2];
	double sqrtVal = sqrt(b*b - 4 * a*c);
	result[0] = (-b + sqrtVal) / (2 * a);
	result[1] = (-b - sqrtVal) / (2*a);
	return result;
}

bool check(double a, double b, double c, double root1, double root2) {
	double ans1 = a * root1*root1 + b * root1 + c;
	double ans2 = a * root2*root2 + b * root2 + c;
	const double accuracy = .00001;

	cout << "first root gives" << ans1 << endl;
	cout << "second root gives" << ans2 << endl;

	if (ans1 < accuracy && ans2 < accuracy) {
		return true;
	}
	else {
		return false;
	}
	
}


int main() {
	double a, b, c;
	double *res;

	cout << "Input a, b, c: " << endl;
	cin >> a;
	cin >> b;
	cin >> c;

	if (a==0) {
		cout << "Dividing by zero" << endl;
	}
	if (b*b - 4 * a*c < 0) {
		cout << "no  square root" << endl;
	}
	res = roots(a, b, c);

	cout << "Roots are: " << res[0] << " , " << res[1] << endl;

	if (check(a, b, c, res[0], res[1]))
		cout << "Roots are correct" << endl;
	else
		cout << "Roots are incorrect" << endl;

	delete res;
	system("pause");
}