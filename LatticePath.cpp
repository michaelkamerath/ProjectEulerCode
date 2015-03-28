#include <iostream>

long long generateFactorial(int number)
{
	long long result = 1;
	for (int i = 1; i < number; ++i)
	{
		result *= i;
	}
	return result;
}

long long generateCombination(int possibilities, int outcomes)
{
	return generateFactorial(possibilities) / generateFactorial(outcomes);
}

int main()
{
	std::cout << "The number of lattice paths in a 10X10 matrix is " << generateCombination(20, 10) << std::endl;

	system("PAUSE");
	return 0;
}