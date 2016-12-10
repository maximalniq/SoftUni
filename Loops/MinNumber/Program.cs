using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int min = 0;


            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    min = num;
                }
                else if (min > num)
                {
                    min = num;
                }

            }

            Console.WriteLine(min);
        }
    }
}
