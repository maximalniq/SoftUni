using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= length; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
