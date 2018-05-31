using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var k = int.Parse(Console.ReadLine());

            var rotatedArray = new int[arrayOfNumbers.Length];
            var sumArray = new int[arrayOfNumbers.Length];

            for (int i = 0; i < k; i++)
            {
                    for (int j = 0; j < arrayOfNumbers.Length - 1; j++)
                    {
                        rotatedArray[j + 1] = arrayOfNumbers[j];
                        var lastElement = arrayOfNumbers[rotatedArray.Length - 1];
                        rotatedArray[0] = lastElement;
                    }
                for (int y = 0; y < rotatedArray.Length; y++)
                {
                    arrayOfNumbers[y] = rotatedArray[y];
                }

                for (int o = 0; o < arrayOfNumbers.Length; o++)
                {
                    sumArray[o] += rotatedArray[o];
                }
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
