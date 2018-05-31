using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom2_0To2_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 0; i <= length; i++)
            {
                Console.WriteLine(num);
                num *= 2;
            }
        }
    }
}
