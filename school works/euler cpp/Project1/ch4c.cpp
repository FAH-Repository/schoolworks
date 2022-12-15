#include < iostream>
#include <cmath>
#include <string>
#include <vector>
using namespace std;
/*
used a vector with set vals, just changed it to use user input
*/

static void game(void) {
	//string inp;
	int i = 0;
	char mplay;
	char inp;
	int comp;
	bool playing = true;

	cout << "enter r, p, or s, for rock, paper, or scissors:\n";


	cin >> inp;
	cout << "give the computer an integer value\n";
	cin >> comp;
	vector<int> v = { comp };
	//while (playing == true) {
	if (v[i] % 2 == 0) {
		mplay = 'r';
	}
	else if (v[i] % 3 == 0) {
		mplay = 'p';
	}
	else {
		mplay = 's';
	}
	switch (inp) {
	case 'r':
		if (mplay == 'r') {
			cout << "tie";
		}
		else if (mplay == 'p') {
			cout << "computer won";
		}
		else {
			cout << "you win!";
		}
		break;
	case 'p':
		if (mplay == 'r') {
			cout << "you win!";
		}
		else if (mplay == 'p') {
			cout << "tie";
		}
		else {
			cout << "computer wins";
		}
		break;


	case 's':
		if (mplay == 'r') {
			cout << "computer wins";
		}
		else if (mplay == 'p') {
			cout << "you win!";
		}
		else {
			cout << "tie";
		}
		break;

		i++;
		playing = false;
	}
}

int main(void) {
	begin:
	char p = 'y';
	game();
	
	cout << ", play again? (y/n)\n";
	cin >> p;
	while (p == 'y') {
		goto begin;
		
	}
	


}