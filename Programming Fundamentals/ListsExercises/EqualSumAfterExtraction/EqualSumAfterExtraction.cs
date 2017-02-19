using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < firstList.Count(); i++)
            {
                for (int j = 0; j < secondList.Count(); j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        secondList.RemoveAll(item => item == secondList[j]);
                    }
                }
            }
            if (firstList.Sum() == secondList.Sum())
            {
                Console.WriteLine($"Yes. Sum: {firstList.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstList.Sum() - secondList.Sum())}");
            }
           
        }
    }
}
