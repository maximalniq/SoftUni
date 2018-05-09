using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnRectangleBorder
{
    class PointOnRectangleBorder
    {
        static void Main(string[] args)
        {
            var x1 = decimal.Parse(Console.ReadLine());
            var y1 = decimal.Parse(Console.ReadLine());
            var x2 = decimal.Parse(Console.ReadLine());
            var y2 = decimal.Parse(Console.ReadLine());
            var x = decimal.Parse(Console.ReadLine());
            var y = decimal.Parse(Console.ReadLine());



            if ((x == x1 || x == x2) && (y >= y1) && (y <= y2) || (y == y1 || y == y2) && (x >= x1) && (x <= x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}
