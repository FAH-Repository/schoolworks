#include < iostream>
#include <cmath>
using namespace std;

int main() {
	int tile = 0;
	int rice;
	int ricegoal;
	int total = 0;

	cout << "give the amount of rice:\n";
	cin >> ricegoal;
	while (total < ricegoal) {
			rice = (pow(2, tile));
			total += rice;
			tile++;
			
		}
	cout << "this many tiles you need for that much rice: " << tile << endl;
	

/*
thought it initialy wanted it the other way around
	for (int i = 0; i < tile; i++) {
		rice = (pow(2, i));
		total += rice;
	
	}
	cout << "this is how much rice that many tiles gives: " << total << endl;
	*/
	system("pause");
}