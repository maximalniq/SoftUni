using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var secondArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (firstArray.Length >= secondArray.Length)
            {
                int[] resultArray = new int[firstArray.Length];

                for (int i = 0; i < firstArray.Length; i++)
                {
                    int index = i % secondArray.Length;
                    resultArray[i] = firstArray[i] + secondArray[index];
                }

                Console.WriteLine(string.Join(" ", resultArray));
            }
            else
            {
                int[] resultArray = new int[secondArray.Length];

                for (int i = 0; i < secondArray.Length; i++)
                {
                    int index = i % firstArray.Length;
                    resultArray[i] = firstArray[index] + secondArray[i];
                }

                Console.WriteLine(string.Join(" ", resultArray));
            }
        }
    }
}
