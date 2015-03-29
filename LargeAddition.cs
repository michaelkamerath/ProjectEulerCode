using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class LargeAddition
{
    public LargeAddition()
    {
        string[] numbers = new string[100];
        int totalLines = 0;
        string line;

        try
        {
            using (StreamReader inputFile = new StreamReader("Numbers.txt"))
            {
                while ((line = inputFile.ReadLine()) != null)
                {
                    line = line.Substring(0, 13);
                    numbers[totalLines] = line;
                    ++totalLines;
                }
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("The File could not be found");
            Console.WriteLine(e);
        }

        long result = 0;
        for (int i = 0; i < totalLines; ++i)
        {
            result += long.Parse(numbers[i]);
        }

        Console.WriteLine("The first 10 digits of the sum of 100 fifty digit numbers is: {0}", result);
    }
}