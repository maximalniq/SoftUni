using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var minNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < length - 1; i++)
            {
                var numberToRead = int.Parse(Console.ReadLine());

                if (minNumber > numberToRead)
                {
                    minNumber = numberToRead;
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}
