#include <iostream>
#include <vector>
#include <cmath>
#include <time.h>

void markNumbers(std::vector<bool>&markings ,long int a,long int multiples)
{
	long int i = 2, number;
	while ((number = i * a) < multiples)
	{
		markings.at(number-1) = true;
		++i;
	}
}

void generatePrimes(std::vector<long int> &primeList, long int num)
{
	if (num >= 2)
	{
		std::vector<bool>markers;
		markers.resize(2000000);
		std::fill(markers.begin(), markers.end(), false);
		primeList.push_back(2);	

		for (int i = 2; i < num; i+=2)
		{
			if (!markers.at(i))
			{
				primeList.push_back(i + 1);
				markNumbers(markers, i + 1, num);
			}
		}
	}
}

int main()
{
	using namespace std;
	vector<long int> primeList;
	unsigned long long int result = 0;
	long int maxValue = 2000000;

	double duration;
	clock_t start = clock();
	generatePrimes(primeList, maxValue);

	for (int c : primeList)
	{
		result += c;
	}

	cout << "The summation of all primes under " << maxValue << " is " << result << endl;

	duration = (clock() - start) / (double)CLOCKS_PER_SEC;

	cout << "This calculation took " << duration << " seconds" << endl;

	system("PAUSE");
	return 0;
}