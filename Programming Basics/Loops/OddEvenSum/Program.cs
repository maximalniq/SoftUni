using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenSum = 0;
            int oddSum = 0;

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (i % 2 == 0 )
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            if (Math.Abs(evenSum - oddSum ) == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum == {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",Math.Abs(oddSum - evenSum));
            }
        }
    }
}
