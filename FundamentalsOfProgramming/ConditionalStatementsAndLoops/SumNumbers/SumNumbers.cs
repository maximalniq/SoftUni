using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < counter; i++)
            {
                var numberToSum = int.Parse(Console.ReadLine());
                sum += numberToSum;
            }

            Console.WriteLine(sum);
        }
    }
}
