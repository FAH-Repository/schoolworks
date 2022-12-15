#include <iostream>
using namespace std;
/*
Forest H.
Repeat the previous exercise, but with a class Number<T> where T can be any numeric type.
Try adding % to Number and see what happens when you try to use % for
Number<double> and Number<int>.

Just wrote out yours couldnt get mine to work :(
*/
template <class T>
class my_T {
public:
	my_T(const T val=0): value(val) { }
	my_T(const my_T & my_val):value(my_val.value) { }
	~my_T() {}
	
	my_T & operator=(const T & val) {
		value = val;
		return *this;
	}
	my_T & operator=(const my_T & my_val) {
		value = my_val.value;
		return *this;
	}

	my_T operator+(const T & val) {
		my_T result;
		result.value = value + val;
		return result;
	}
	my_T operator+(const my_T & my_val) {
		my_T result;
		result.value = value + my_val.value;
		return result;
	}
	my_T operator-(const T & val) {
		my_T result;
		result.value = value - val;
		return result;
	}
	my_T operator-(const my_T & my_val) {
		my_T result;
		result.value = value - my_val.value;
		return result;
	}
	my_T operator*(const T & val) {
		my_T result;
		result.value = value * val;
		return result;
	}
	my_T operator*(const my_T & my_val) {
		my_T result;
		result.value = value * my_val.value;
		return result;
	}
	my_T operator/(const T & val) {
		my_T result;
		result.value = value / val;
		return result;
	}
	my_T operator/(const my_T & my_val) {
		my_T result;
		result.value = value / my_val.value;
		return result;
	}
/*
 * I am inlining the definition of operator<< and operator>>
 * because c++ has trouble figuring out that the operator<<
 * or operator>> is a templated operator otherwise.
 * the book is not really clear on this or it isn't really 
 * presented at this point in the text.
 */
		

	friend ostream & operator<<(ostream & os, const my_T & my_val) {
		return os << "[" << my_val.value << "]";
	}
	friend istream & operator>>(istream & is, my_T & my_val) {
		return is >> my_val.value;
	}
	
private:
	T value;
};



int main() {
	my_T<double> m1;
	my_T<double> m2(3);
	my_T<double> m3(m2);


	cout << m1 << endl;
	cout << m2 << endl;
	cout << m3 << endl;

	my_T<double> m4 = m2;
	m1 = 7;
	m2 = m1;
	m3 = m1 = m2;


	cout << m1 << endl;
	cout << m2 << endl;
	cout << m3 << endl;
	cout << m4 << endl;

	m3 = m2+m1;
	m4 = m4+1;
	cout << m3 << endl;
	cout << m4 << endl;

	cout << m1*m2 << endl;
	cout << m4/m3 << endl;
	cout << m3 - 2 - 5 << endl;

	cout <<"Enter two myvals: " << endl;
	cin >> m4 >>m3;
	cout << "m4,m3: " << m4 << ", " <<m3 <<endl;

	cout << "m4+m3: "<< m4 +m3 << endl;
}
