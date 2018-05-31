using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfIntegers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main(string[] args)
        {
            var numberOfIndexes = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[numberOfIndexes];

            for (int i = numberOfIndexes - 1; i >= 0; i--)
            {
                var numberToRead = int.Parse(Console.ReadLine());
                arrayOfNumbers[i] = numberToRead;
            }

            Console.WriteLine(string.Join(" ", arrayOfNumbers));

        }
    }
}
