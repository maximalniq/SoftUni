using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            int i = 0;

            while (i < numbers.Count() - 1)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.Remove(numbers[i + 1]);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

                Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
