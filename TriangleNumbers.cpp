#include <iostream>
#include <math.h>
#include <vector>

using namespace std;

int getNumDivisors(int number)
{
	int numDivisors = 2;
	int i = 2;
	while (pow(i, 2) < number/2)
	{
		if (number % i == 0)
		{
			numDivisors += 2;
		}
		++i;
	}
	return numDivisors;
}

void generateTriangularNumber(int maxNumber, vector<int>& nums)
{
	int result = 0;
	for (int i = 0; i < maxNumber; ++i)
	{
		result += i;
		nums.push_back(result);
	}
}

int findTriangularNumber(vector<int> nums)
{
	int count = 0;
	for (int temp : nums)
	{
		int result = getNumDivisors(temp);
		if (result >= 500)
		{
			break;
		}
		++count;
	}
	return nums.at(count);
}



//int main()
//{
//	const int maxNumber = 20000;
//	vector<int> triangularNumbers;
//	generateTriangularNumber(maxNumber, triangularNumbers);
//
//	
//	int result = findTriangularNumber(triangularNumbers);
//
//	cout << "The first triangular number with more than 500 divisors is " << result << endl;
//
//	system("PAUSE");
//	return 0;
//}