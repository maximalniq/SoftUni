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
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && c + b > a )
            {
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }

            if (a * a + b * b == c * c)
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");

            }
            if (b * b + c * c == a * a)
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");

            }
            if (c * c + a * a == b * b)
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");

            }

            if (a + b > c && a * a + b * b != c * c && b * b + c * c != a * a && c * c + a * a != b * b)
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
    }
}
