using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                do
                {
                    Console.WriteLine(num2);
                    num2++;
                } while (num2 <= num1);
            }
            else
            {
                do
                {
                    Console.WriteLine(num1);
                    num1++;
                } while (num1 <= num2);
            }
        }
    }
}
