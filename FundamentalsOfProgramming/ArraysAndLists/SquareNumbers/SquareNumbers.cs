using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < input.Count(); i++)
            {
                double resultNumber = Math.Sqrt(input[i]);
                if (resultNumber % 1 == 0)
                {
                    resultList.Add(input[i]);
                }
            }

            resultList.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
