using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = float.Parse(Console.ReadLine());
            var h = float.Parse(Console.ReadLine());
            var area = a * h / 2;
            Console.WriteLine("Triangle area = " + Math.Round(area,2));

        }
    }
}
