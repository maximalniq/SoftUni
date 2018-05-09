using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var firstNumber = int.Parse(Console.ReadLine());
            int maxNumber = firstNumber;

            for (int i = 0; i < counter - 1; i++)
            {
                var numberToRead = int.Parse(Console.ReadLine());

                if (numberToRead > maxNumber) maxNumber = numberToRead;
            }

            Console.WriteLine(maxNumber);
        }
    }
}
