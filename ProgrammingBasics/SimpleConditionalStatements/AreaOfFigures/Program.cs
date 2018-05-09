using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a;
            double b;
            double r;
            double h;
            double area;            

            if (figure == "square")
            {
                a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine(area);
            }
            else if (figure == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine(area);
            }
            else if (figure =="circle")
            {
                r = double.Parse(Console.ReadLine());
                area = Math.PI * (r * r);
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                area = (a * h) / 2;
                Console.WriteLine(area);
            }
        }
    }
}
