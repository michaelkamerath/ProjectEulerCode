using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

    class PalindromeNumber
    {
        public PalindromeNumber()
        {
            int maxPalindrome = 0;
            bool isFound = false;
            for (int i = 999; i > 100; --i)
            {
                int checkNum = 0;
                for (int j = 990; j > 100; j-=11)
                {
                    checkNum = i * j;
                    if (isPalindrome(checkNum) && checkNum > maxPalindrome)
                    {
                        maxPalindrome = checkNum;
                        break;
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("The largest palindrome that is the product of 2 three digit numbers is: {0}", maxPalindrome);
        }

        public static bool isPalindrome(int num)
        {
            int reverseNum = 0;
            int temp = num;
            while (temp > 0)
            {
                int digit = temp % 10;
                reverseNum = reverseNum * 10 + digit;
                temp = temp / 10;
            }
            if (num == reverseNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
