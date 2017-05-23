using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMethod
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            var num0 = int.Parse(Console.ReadLine());
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            GetMin(num0, num1, num2);
        }

        private static void GetMin(int a, int b, int c)
        {
            if (a > b && c > b)
            {
                Console.WriteLine(b);
            }
            if (b > a && c > a)
            {
                Console.WriteLine(a);
            }
            if (a > c && b > c)
            {
                Console.WriteLine(c);
            }
            return;
        }
    }
}
