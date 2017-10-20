using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(' ');
            string consecutiveEqualStrings = string.Empty;
            string currentString = arr[0];
            int consecutiveEqualStringsCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (currentString == arr[i])
                {
                    consecutiveEqualStringsCounter++;
                }
                if (consecutiveEqualStringsCounter == 3)
                {
                    consecutiveEqualStrings = arr[i];
                    consecutiveEqualStringsCounter = 0;
                }
                currentString = arr[i];
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{consecutiveEqualStrings} ");
            }
        }
    }
}
