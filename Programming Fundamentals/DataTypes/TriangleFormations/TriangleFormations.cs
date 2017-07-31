using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFormations
{
    class TriangleFormations
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Triangle is valid.");

                if (a * a + b * b == c * c)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (a * a + c * c == b * b)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (b * b + c * c == a * a)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
