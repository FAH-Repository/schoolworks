/*
Forest H.
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.


this one is largely the same as problem 7, ran into some issues printing the right answer, but map fixed things up.
Also one thing that i have noticed is that I often use a tool to get the target answer, and then use some of my own test cases to make sure it works for multiple cases
but if i run into a problem where the numerical answer is not found that i can program towards how might i find these answers myself?
some i can just do the math for, but as far as i can tell jsut going over the code step by steps sometimes seems like the only way to check, that relies on my always being right though...
*/

#include <iostream>
#include <vector>
#include <map>
using namespace std;
int main()
{
	vector <unsigned int> primes;

	primes.push_back(2);
	
	for (unsigned int x = 3; x <= 2000000; x += 2)
	{
		bool isPrime = true;
		for (auto p : primes)
		{
			if (p*p > x) 
				break;
			
			if (x % p == 0)
			{
				isPrime = false;
				break;
			}
		}
		if (isPrime) {
			primes.push_back(x);
		}
		}
	map<unsigned int, unsigned long long> sums;
	unsigned long long sum = 0;
	for (auto p: primes) {
		sum += p;
		sums[p] = sum;
	}
	cout << sum;
	system("pause");
	return 0;
}