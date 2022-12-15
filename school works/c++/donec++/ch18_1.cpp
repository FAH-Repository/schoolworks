#include <iostream>
#include <string>
#include <string.h>
using namespace std;

/*
Forest H.
1. Write a function, char* strdup(const char*), that copies a C-style string into memory it
allocates on the free store. Do not use any standard library functions. Do not use subscripting;
use the dereference operator * instead.

Yours much better, old at bottom as usual
*/


int charStrLen(const char *inpt) {
	const char *cp = inpt;
	int sz = 0;
	while (*cp++ != '\0')
		sz++;
	return sz;
}

char *strdup(const char *inpt ) {
	//int n = strlen(inpt)+1; this is the standard library fun for length
	int n = charStrLen(inpt)+1;
	char * cpy = new char[n];
	char *p = cpy;
	const char *cp = inpt;
/*
 * assume inpt correctly formed with null terminator
 */
	while ( (*p++ = *cp++) != '\0')
		;
	return cpy;
}

int main() {
	string *c = new string{"a string"} ;
	char *d = strdup(c->c_str());
	cout << "Original: " << *c << endl;
	cout << "Copy: " << d << endl;

	delete d;
}
/*
char* strdupl(const char* s) {
// get size of s
int i = 0;
const char* p = s;
while (*p++) ++i;

// allocate new string, add space for terminating 0
char* s_cpy = new char[i+1];

// copy s, add terminating 0
char* s_cpy_ptr = s_cpy;
while (*s) *s_cpy_ptr++ = *s++;
*s_cpy_ptr = 0;
return s_cpy;
}

char* findx(const char* s, const char* x) {
if (x==0 || !*x) return const_cast<char*>(s);
if (s==0 || !*s) return 0;

for (int i = 0; *(s+i); ++i) {
if (*(s+i) == *x) {
for (int j = 0; *(x+j); ++j) {
if (!*(s+i+j)) return 0;    // reached end of s
if (*(s+i+j)!=*(x+j)) break;    // x not found
if (!*(x+j+1)) return const_cast<char*>(s+i);   // found x
}
}
}
return 0;   // reached end of s
}

int strcmp(const char* s1, const char* s2) {
if (s1==0||s2==0) error("Null pointer sent to strcmp()");
for (int i = 0; *(s1+i); ++i) {
// if only s1 ends or s1[i]<s2[i], s1<s2
if (*(s1+i)==0 && *(s2+i) || *(s1+i) < *(s2+i)) return -1;

// if only s2 ends or s1[i]>s2[i], s1>s2
if (*(s2+i)==0 && *(s1+i) || *(s1+i) > *(s2+i)) return 1;
}

// s1 and s2 are identical
return 0;
}

void print_str(const char* s) {
if (s==0) error("Cannot print from null pointer");
while (*s) cout << *s++;
}

int main()
try {
// test exercise 1
char s[] = "Test";
char* s_cpy = strdupl(s);
print_str(s_cpy);
cout << "\n";
delete[] s_cpy;

// test exercise 2
char s2[] = "This is a test phrase";
char x[] = "test";
cout << "s: " << s2 << "\n";
cout << "x: " << x << "\n";
print_str(findx(s2,x));
cout << "\n";

// test exercise 3
const int max = 5;
char a[max];
char b[max];
while (cin>>a>>b) {
int comp = strcmp(a,b);
switch (comp) {
case -1:
cout << a << " < " << b << "\n";
break;
case 0:
cout << a << " == " << b << "\n";
break;
case 1:
cout << a << " > " << b << "\n";
break;
default:
error("invalid result returned by strcmp");
break;
}
}
}
catch (exception& e) {
cerr << "exception: " << e.what() << endl;
}
catch (...) {
cerr << "exception\n";
}


*/