using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractNumberFromArray
{
    class ExtractNumberFromArray
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (arrayOfNumbers.Count() == 1)
            {
                Console.WriteLine("{ " + arrayOfNumbers[0] + " }");
            }
            else if (arrayOfNumbers.Count() % 2 == 0)
            {
                Console.WriteLine("{ " + arrayOfNumbers[(arrayOfNumbers.Length/2) - 1] + ", " + arrayOfNumbers[arrayOfNumbers.Length / 2] + " }");
            }
            else if (arrayOfNumbers.Count() % 2 != 0)
            {
                Console.WriteLine("{ " + arrayOfNumbers[(arrayOfNumbers.Length / 2) - 1] + ", " + arrayOfNumbers[arrayOfNumbers.Length / 2] + ", " + arrayOfNumbers[(arrayOfNumbers.Length / 2) + 1] + " }");
            }
        }
    }
}
