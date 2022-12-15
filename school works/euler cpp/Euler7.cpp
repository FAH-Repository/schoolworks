/*
Forest H
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?

104743
*/
#include <iostream>
#include <vector>

using namespace std;
int main()
{
	// computes the first 10001 primes, you could just take the last one, but i thought it might be useful for later works to have this as a reference,
	// also you have to loop through it anyway i think, unless there is some shortcut

	vector <int> primes;
	primes.reserve(10001);
	primes.push_back(2);
	for (unsigned int x = 3; primes.size() <= 10000; x += 2)
	{
		bool isPrime = true;
		for (auto p : primes)
		{
			// found a divisor ? => abort
			if (x % p == 0)
			{
				isPrime = false;
				break;
			}
			// no larger prime factors possible ?
			if (p*p > x)
				break;
		}

		// yes, we have a new prime, add it in
		if (isPrime) {
			primes.push_back(x);
		}
		
	}
	cout << primes.back() << endl;
	system("pause");
	return 0;
}
