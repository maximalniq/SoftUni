using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromTerabytesToBits
{
    class TerabytesToBits
    {
        static void Main(string[] args)
        {
            var TB = float.Parse(Console.ReadLine());
            decimal bits = (decimal)TB * (1024M * 1024M * 1024M * 1024M * 8M);

            Console.WriteLine("{0:f0}", bits);
        }
    }
}
