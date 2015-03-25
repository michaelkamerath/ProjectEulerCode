using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

    class FindPythagoreanTriplet
    {
        public FindPythagoreanTriplet()
        {
            const int upperBoundSum = 1000;
            bool found = false;
            int greatestProduct = 0;
            for (int m = (int)Math.Sqrt(upperBoundSum); m > 0; --m)
            {
                for (int n = (int)Math.Sqrt(upperBoundSum); n > 0; --n)
                {
                    int a = (int)Math.Pow(m, 2) - (int)Math.Pow(n, 2);
                    int b = 2 * m * n;
                    int c = (int)Math.Pow(m, 2) + (int)Math.Pow(n, 2);
                    int sum = a + b + c;

                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        if (sum == 1000)
                        {
                            greatestProduct = a * b * c;
                            found = true;
                            break;
                        }
                    }
                }
                if (found)
                {
                    break;
                }
            }
            Console.WriteLine("The product of a pythagorean triple in which a + b + c = 1000 is: {0}", greatestProduct);
        }
    }
