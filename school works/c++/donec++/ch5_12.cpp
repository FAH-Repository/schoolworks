#include "std_lib_facilities.h"

/*
Forest H.
Implement a little guessing game called (for some obscure reason) “Bulls and Cows.” The
program has a vector of four different integers in the range 0 to 9 (e.g., 1234 but not 1122) and
it is the user’s task to discover those numbers by repeated guesses. Say the number to be
guessed is 1234 and the user guesses 1359; the response should be “1 bull and 1 cow” because
the user got one digit (1) right and in the right position (a bull) and one digit (3) right but in the
wrong position (a cow). The guessing continues until the user gets four bulls, that is, has the
four digits correct and in the correct order

 */

int bulls = 0;
int cows = 0;

// puts new numbers into solution vector
vector<int> get_new_sol()
{
	vector<int> sol(4);
	sol[0] = randint(10);
	sol[1] = randint(10);
	sol[2] = randint(10);
	sol[3] = randint(10);
	return sol;
}

// turns an integer into a vector
vector<int> int_to_vector(int n)
{
	if (n>9999 || n<0) error("int_to_vector called with wrong number");
	vector<int> v(4);
	v[0] = n / 1000 % 10;
	v[1] = n / 100 % 10;
	v[2] = n / 10 % 10;
	v[3] = n % 10;
	return v;
}

// checks guess for bulls and cows
// first loop for bulls, second loop for cows
void check_guess(vector<int> guess, vector<int> solution)
{
	bulls = 0;
	cows = 0;
	vector<char> is_bull(4, 'n');
	vector<char> is_cow(4, 'n');
	for (int i = 0; i<solution.size(); ++i) {
		if (guess[i] == solution[i]) {
			++bulls;
			is_bull[i] = 'y';
		}
	}
	for (int i = 0; i<solution.size(); ++i) {
		if (is_bull[i] == 'n') {
			for (int j = 0; j<guess.size(); ++j) {
				if (is_bull[j] == 'n' && is_cow[j] == 'n') {
					if (solution[i] == guess[j]) {
						++cows;
						is_cow[j] = 'y';
					}
				}
			}
		}
	}
}

int main()
try {
	int guess = 0;
	int seed = 0;
	cout << "Guess my four digit number! Numbers with less digits will be padded with zeros.\n";
	cout << "Enter seed for random numbers: ";
	cin >> seed;
	srand(seed);
	vector<int> solution = get_new_sol();
	cout << "Enter guess ('q' to exit): ";

	while (cin >> guess) {
		if (guess>9999 || guess<0)
			cout << "Number must be between 0000 and 9999!\n";
		else {
			vector<int> v_guess = int_to_vector(guess);
			check_guess(v_guess, solution);
			if (bulls == 4) {
				cout << "You have guessed the number! Setting new solution...\n";
				solution = get_new_sol();
			}
			if (bulls < 4) {
				cout << "Number of bulls: " << bulls << endl;
				cout << "Number of cows: " << cows << endl;
			}
		}
		cout << "Enter guess ('q' to exit): ";
	}
	cout << "You gave up!\n";
	return 0;
}
catch (exception& e) {
	cerr << "Error: " << e.what() << endl;
	//keep_window_open();
	return 1;
}
catch (...) {
	cerr << "Unknown exception!\n";
	return 2;
}