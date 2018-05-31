using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var newNumbers = new List<int>();

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] > 0)
                {
                    newNumbers.Add(numbers[i]);
                }
            }

            if (newNumbers.Count() == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                newNumbers.Reverse();
                Console.WriteLine(string.Join(" ", newNumbers));
            }
        }
    }
}
