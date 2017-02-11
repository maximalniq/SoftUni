using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersOddPositions
{
    class OddNumbersOddPositions
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0 && arr[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {arr[i]}");
                }
            }
        }
    }
}
