using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine(num);
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    num *= 4;
                    Console.WriteLine(num);
                }
               
            }
        }
    }
}
