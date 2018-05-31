using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var difference = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int p = i + 1; p < arr.Length; p++)
                {
                    if (arr[i] - arr[p] == difference)
                    {
                        counter++;
                    }
                    else if (arr[p] - arr[i] == difference)
                    {
                        counter++;
                    }
                }

            }

            Console.WriteLine(counter);
        }
    }
}
