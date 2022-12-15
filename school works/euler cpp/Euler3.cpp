#include <iostream> 

using namespace std;

// finds largest prime factor of 600851475143, though other numbers can be substituted in n 
long long maxPrimeFactors(long long n)
{
	long long maxPrime = -1;	
	while (n % 2 == 0) {
		maxPrime = 2;
		n >>= 1; 
	}


	for (int i = 3; i <= sqrt(n); i += 2) {
		while (n % i == 0) {
			maxPrime = i;
			n = n / i;
		}
	}
	if (n > 2)
		maxPrime = n;

	return maxPrime;
}

int main()
{
	n = 600851475143;
	cout << maxPrimeFactors(n);

	system("pause");
}