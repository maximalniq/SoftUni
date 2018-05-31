using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromNTo1Backwards
{
    class NumbersFromNTo1Backwards
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());

            for (int i = length; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
