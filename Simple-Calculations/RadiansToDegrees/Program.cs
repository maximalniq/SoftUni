using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            double degreese = (radians * 180) / Math.PI;

            Console.WriteLine(Math.Round(degreese));
        }
    }
}
