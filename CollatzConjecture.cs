using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CollatzConjecture
    {
        public CollatzConjecture()
        {
            const int maxNumber = 1000000;

            int longestStepsRequired = 0;
            int largestSequenceNumber = 0;
            long sequenceNumber;

            int[] numSteps = new int[maxNumber + 1];
            for (int i = 0; i < numSteps.Length; ++i)
            {
                numSteps[i] = -1;
            }
            numSteps[1] = 1;

            for (int i = 2; i < maxNumber; ++i)
            {
                sequenceNumber = i;
                int counter = 0;
                while (sequenceNumber != 1 && sequenceNumber >= i)
                {
                    ++counter;
                    if (sequenceNumber % 2 == 0)
                    {
                        sequenceNumber /= 2;
                    }
                    else
                    {
                        sequenceNumber = sequenceNumber * 3 + 1;
                    }
                }
                numSteps[i] = counter + numSteps[sequenceNumber];
                if (numSteps[i] > longestStepsRequired)
                {
                    longestStepsRequired = numSteps[i];
                    largestSequenceNumber = i;
                }
            }
            Console.WriteLine("The number with the most number of steps for the Collatz Conjecture is: {0} ", largestSequenceNumber);
            Console.WriteLine("The number of steps required to reach 1 is: {0} ", longestStepsRequired);
        }
    }
