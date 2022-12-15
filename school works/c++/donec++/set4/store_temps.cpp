#include "std_lib_facilities.h"

using namespace std;

struct Reading {
	double hour;
	double temperature;
};

int main() {
	ofstream ost("raw_temps.txt");
	Reading *data = new Reading[60] ;
	int j;
	double i;

	default_random_engine generator;
	uniform_int_distribution<int> distribution(50, 80);

	if (!ost)
		error("Output stream no good");

	for(j=0, i=0; i<25; i=i+.50, j++) {
		data[j].hour = i;
		data[j].temperature = distribution(generator);

		ost << data[j].hour << " " << data[j].temperature << endl;
	}
	
}
