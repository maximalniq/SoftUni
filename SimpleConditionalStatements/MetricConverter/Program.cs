using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            double meters = 0;
            double result = 0;

            if (from == "mm")
            {
                meters = number * 1000;             
            }
            if (from == "cm")
            {
                meters = number * 100;
            }
            if (from == "mi")
            {
                meters = number * 0.000621371192;
            }
            if (from == "in")
            {
                meters = number * 39.3700787;
            }
            if (from == "km")
            {
                meters = number * 0.001;
            }
            if (from == "ft")
            {
                meters = number * 3.2808399;
            }
            if (from == "yd")
            {
                meters = number * 1.0936133;
            }
            // To ifs
            if (to == "mm")
            {
                result = meters / 1000;
            }
            if (to == "cm")
            {
                result = meters / 100;
            }
            if (to == "mi")
            {
                result = meters / 0.000621371192;
            }
            if (to == "in")
            {
                result = meters / 39.3700787;
            }
            if (to == "km")
            {
                result = meters / 0.001;
            }
            if (to == "ft")
            {
                result = meters / 3.2808399;
            }
            if (to == "yd")
            {
                result = meters / 1.0936133;
            }

            Console.WriteLine(result + " " + to);
        }
    }
}
