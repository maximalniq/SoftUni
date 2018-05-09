using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                var number = double.Parse(Console.ReadLine());
                Console.WriteLine(number * number);
            }

            else if (figure == "rectangle")
            {
                var number = double.Parse(Console.ReadLine());
                var number2 = double.Parse(Console.ReadLine());
                Console.WriteLine(number * number2);
            }

            else if (figure == "circle")
            {
                var number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * (number * number):f3}");
            }

            else if (figure == "triangle")
            {
                var number = double.Parse(Console.ReadLine());
                var number2 = double.Parse(Console.ReadLine());
                Console.WriteLine((number * number2) / 2);
            }
        }
    }
}
