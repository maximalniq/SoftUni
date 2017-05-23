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
            byte number = 0;
            int counter = 0;

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                number++;
                if (number == 255)
                {
                    counter++;
                }
            }
            Console.WriteLine("{0}", number);
            Console.WriteLine("Overflowed {0} times", counter);
        }
    }
}
