#include "std_lib_facilities.h"

using namespace std;

double sumUp (istream & ist) {
	double sum = 0;
	double n;
	while (ist >> n) {
		sum += n;
	}
	return sum;
}

int main(int argc, char ** argv) {
	if (argc != 2) 
		error("Usage: ./read filename" );
	
	ifstream ist(argv[1]);
	if (!ist)
		error("Can't open file");
	
	cout << "Here is the sum: " << sumUp(ist) << endl;
}


