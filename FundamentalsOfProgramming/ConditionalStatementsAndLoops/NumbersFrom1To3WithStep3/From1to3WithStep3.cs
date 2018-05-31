using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1To3WithStep3
{
    class From1to3WithStep3
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());

            for (int i = 1; i <= length; i+= 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
