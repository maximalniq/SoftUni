using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            double b = Math.Max(x1, x2) - Math.Min(x1, x2);
            double a = Math.Max(y1, y2) - Math.Min(y1, y2);
            double area = a * b;
            double perimeter = (a * 2) + (b * 2);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
            
        }
    }
}
