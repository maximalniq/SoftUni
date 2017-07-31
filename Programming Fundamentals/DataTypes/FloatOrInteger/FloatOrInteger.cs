using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrInteger
{
    class FloatOrInteger
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(number));
        }
    }
}
