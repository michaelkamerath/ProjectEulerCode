#include <iostream>
#include <vector>
#include <iterator>
#include <string>



int main()
{
	std::string input;
	std::cout << "Enter the power of 2 which you want to know the sum of the digits for " << std::endl;
	getline(std::cin, input);

	std::vector<int> digits;
	digits.push_back(1);

	int power = atoi(input.c_str());
	for (int i = 0; i < power; ++i)
	{
		int carry = 0;
		for (std::vector<int>::iterator iter = digits.begin(); iter < digits.end(); ++iter)
		{
			int digit = *iter;
			digit = 2 * digit + carry;
			carry = digit / 10;
			digit = digit % 10;
			*iter = digit;
		}
		if (carry != 0)
		{
			digits.push_back(carry);
		}
	}

	int result = 0;
	for (int number : digits)
	{
		result += number;
	}

	std::cout << "The sum of all of the digits of 2^1000 is " << result << std::endl;

	system("PAUSE");
	return 0;
}
