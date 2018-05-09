using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = num;
                }
                else if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
