#include <iostream>
using namespace std;
/*
Forest H.
Define a class Int having a single member of class int. Define constructors, assignment, and
operators +, ?, *, / for it. Test it, and improve its design as needed (e.g., define operators <<
and >> for convenient I/O).

thought i got it working now it isnt, maybe i changed something and forgot
*/

class Int {
	int val;
public:
	Int() : val(0) { }                      // default constructor
	Int(const Int& arg) : val(arg.val) { }  // gratuitous copy constructor
	Int(int v) : val(v) { }                 // constructor
	Int& operator=(const Int& v) { val = v.val; }   // gratuitous copy assignment
	int get() const { return val; }
	
};

Int operator+(const Int& v1, const Int& v2)
{
	return Int(v1.get() + v2.get());
}


Int operator-(const Int& v1, const Int& v2)
{
	return Int(v1.get() - v2.get());
}


Int operator*(const Int& v1, const Int& v2)
{
	return Int(v1.get() * v2.get());
}


Int operator/(const Int& v1, const Int& v2)
{
	return Int(v1.get() / v2.get());
}


ostream& operator<<(ostream& os, const Int& d)
{
	os << d.get();
	return os;
}

int main()
try {
	Int i1;
	Int i2 = 2;
	Int i3(i2);
	Int i4;
	i4 = i2;
	Int i5 = 6;
	cout << "i1 (default constructed): " << i1 << "\n";
	cout << "i2 (constructed with argument): " << i2 << "\n";
	cout << "i3 (copy constructed from i2): " << i3 << "\n";
	cout << "i4 (copy assigned  from i2): " << i4 << "\n";
	cout << "i5 (constructed with argument): " << i5 << "\n";
	cout << "i2 + i5 = " << i2 + i5 << "\n";
	cout << "i5 - i2 = " << i5 - i2 << "\n";
	cout << "i2 * i5 = " << i2 * i5 << "\n";
	cout << "i5 / i2 = " << i5 / i2 << "\n";
}
catch (exception& e) {
	cerr << "exception: " << e.what() << endl;
}
catch (...) {
	cerr << "exception\n";
}