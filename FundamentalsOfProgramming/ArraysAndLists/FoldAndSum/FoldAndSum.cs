using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstNumbers = new int[arrayOfNumbers.Length / 4];
            var middleNumbers = new int[arrayOfNumbers.Length / 2];
            var lastNumbers = new int[arrayOfNumbers.Length / 4];

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                firstNumbers[i] = arrayOfNumbers[i];
            }

            Array.Reverse(firstNumbers);

            for (int i = 0; i < middleNumbers.Length; i++)
            {
                middleNumbers[i] = arrayOfNumbers[i + firstNumbers.Length];
            }
            for (int i = 0; i < lastNumbers.Length; i++)
            {
                lastNumbers[i] = arrayOfNumbers[i + firstNumbers.Length + middleNumbers.Length];
            }
            Array.Reverse(lastNumbers);

            var firstRow = new int[firstNumbers.Length + lastNumbers.Length];

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                firstRow[i] = firstNumbers[i];
            }
            for (int i = firstNumbers.Length; i < firstRow.Length; i++)
            {
                firstRow[i] = lastNumbers[i - firstNumbers.Length];
            }

            var sum = new int[arrayOfNumbers.Length / 2];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] += firstRow[i] + middleNumbers[i];
            }


            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
