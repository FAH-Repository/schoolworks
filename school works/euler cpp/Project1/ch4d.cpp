#include "../../std_lib_facilities.h"

vector<int> primes;

bool is_prime(int n)
{
	for (int i = 0; primes[i] <= sqrt(n); ++i) {
		if (n % primes[i] == 0)
			return false;
	}
	return true;
}
int main()
{
	int times = 0;	
	primes.push_back(2);
	int i = 3;
	
	while (primes.size() < 25) {
		if (is_prime(i))
			primes.push_back(i);
		i += 2;
	}
	for (int i = 0; i < primes.size(); ++i)
		cout << primes[i] << endl;
	system("pause");
}