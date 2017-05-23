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
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var resultList = new List<int>();

            for (int i = numbers.Count; i --> 0;)
            {
                if (numbers[i] > 0)
                {
                    resultList.Add(numbers[i]);
                }
            }

            foreach (var item in resultList)
            {
                Console.Write(item + " ");
            }

            if (!resultList.Any())
            {
                Console.WriteLine("empty");
            }
        }
    }
}
