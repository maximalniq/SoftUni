using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            var N = int.Parse(Console.ReadLine());

            FindNthDigit(num, N);
        }

        static int FindNthDigit(long number, int index)
        {
            int currentIndex = 0;
            int Nnumber = 0;
            while (number > 0)
            {
                currentIndex += 1;
                if (currentIndex == index)
                {
                    Nnumber += (int)number % 10;
                    Console.WriteLine(Nnumber);
                }
                else
                {

                    number = number / 10;

                }

            }
            return Nnumber;
            
        }
    }
}
