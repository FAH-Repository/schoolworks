#include < iostream>

using namespace std;
/*
calc the sum of all multiples of 3 or 5, within 1000. Used their example of 10 yielding 23 to test it worked
*/
int main()
{
	int current =0;
	int count =0;
	int total=0;

	while (count < 1000) {
		if (count % 3 == 0 || count % 5 == 0) {
			current = count;
			total += count;
		}
		count++;

	}
	cout << total;
	system("pause");
}