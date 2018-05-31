using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToArray();

            var condensedArray = new double[arrayOfNumbers.Length - 1];

            while (arrayOfNumbers.Length > 1)
            {
                condensedArray = new double[arrayOfNumbers.Length - 1];
                for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
                {
                    condensedArray[i] = arrayOfNumbers[i] + arrayOfNumbers[i + 1];
                }
                arrayOfNumbers = condensedArray;
            }

            Console.WriteLine(condensedArray[0]);
        }
    }
}
