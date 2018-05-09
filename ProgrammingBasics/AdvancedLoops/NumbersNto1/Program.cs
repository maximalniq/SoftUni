using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNto1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = n;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(num);
                num--;
            }
        }
    }
}
