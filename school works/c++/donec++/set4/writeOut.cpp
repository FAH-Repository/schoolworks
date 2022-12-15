
#include "std_lib_facilities.h"

using namespace std;


struct Reading {
	double hour;
	double temperature;
	char which;
};
char choose(int val) {
	switch(val) {
	case 1:	return 'c';
	case 2: return 'f';
	}
}

int main() {
	ofstream ost("cf_raw_temps.txt");
	Reading *data = new Reading[60] ;
	int j;
	double i;

	default_random_engine generator;
	uniform_int_distribution<int> distribution(50, 80);
	uniform_int_distribution<int> which_distribution(1, 2);

	if (!ost)
		error("Output stream no good");

	for(j=0, i=0; i<25; i=i+.50, j++) {
		data[j].hour = i;
		data[j].temperature = distribution(generator);
		data[j].which = choose(which_distribution(generator));

		ost << data[j].hour << " " << data[j].temperature << " " << data[j].which << endl;
	}
	
}
