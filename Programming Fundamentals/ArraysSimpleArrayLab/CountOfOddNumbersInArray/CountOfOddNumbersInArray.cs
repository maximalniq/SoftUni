using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfOddNumbersInArray
{
    class CountOfOddNumbersInArray
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int oddNumbersCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddNumbersCounter++;
                }
            }

            Console.WriteLine(oddNumbersCounter);


        }
    }
}
