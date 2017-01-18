using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var fahrenhait = celsius * 1.8 + 32;
            Console.WriteLine(Math.Round(fahrenhait,2));

        }
    }
}
