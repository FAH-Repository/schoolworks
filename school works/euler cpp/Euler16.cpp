/*
215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 21000?

*/



#include <vector>
#include <iostream>

// store digits
typedef std::vector<unsigned int> Digits;

int main()
{
	std::vector<Digits> cache;
	// add 2^0 = 1
	cache.push_back({ 1 });

	unsigned int tests;
	std::cin >> tests;
	while (tests--)
	{
		unsigned int exponent;
		std::cin >> exponent;

		// and compute the remaining exponents
		for (unsigned int current = cache.size(); current <= exponent; current++)
		{
			auto power = cache.back();
			unsigned int carry = 0;
			for (auto& i : power)
			{
				// times two ...
				i = 2 * i + carry;

				// handle overflow
				if (i >= 10)
				{
					i -= 10;
					carry = 1;
				}
				else
				{
					carry = 0;
				}
			}

			// still some carry left ?
			if (carry != 0)
				power.push_back(carry);
			cache.push_back(power);
		}

		// sum 
		unsigned int sum = 0;
		for (auto i : cache[exponent])
			sum += i;
		std::cout << sum << std::endl;
	}
	system("PAUSE");
	return 0;
}
