using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 1; i < numbers.Count() / 2; i++)
            {
                if (numbers.Count() / 2 != i )
                {
                    int ph = numbers[i];
                    numbers[i] = numbers[numbers.Count() - (i + 1)];
                    numbers[numbers.Count() - (i + 1)] = ph;
                }
            }

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
