using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddSum
{
    class EvenOddSum
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());

            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;

            for (int i = 0; i < length; i++)
            {
                var numberToRead = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumOfEvenNumbers += numberToRead;
                }
                else
                {
                    sumOfOddNumbers += numberToRead;
                }
            }

            if (sumOfEvenNumbers == sumOfOddNumbers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOfEvenNumbers}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumOfEvenNumbers - sumOfOddNumbers)}");
            }
        }
    }
}
