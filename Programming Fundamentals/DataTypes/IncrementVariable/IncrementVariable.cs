using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var counter = 0;
            var oneByte = 256;

            for (int i = 1; i <= n; i++)
            {
                if (i % 256 == 0)
                {
                    counter++;
                }

            }
            var overflowed = Math.Abs((oneByte * counter) - n);

            Console.WriteLine(overflowed);
            Console.WriteLine($"Overflowed {counter} times");
        }
    }
}
