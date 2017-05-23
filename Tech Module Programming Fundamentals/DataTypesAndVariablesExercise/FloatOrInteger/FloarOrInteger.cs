using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrInteger
{
    class FloarOrInteger
    {
        static void Main(string[] args)
        {
            var num = float.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(num));
        }
    }
}
