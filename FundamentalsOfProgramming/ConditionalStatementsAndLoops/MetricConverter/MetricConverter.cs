using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            string metricToConvertFrom = Console.ReadLine();
            string metricToConvertTo = Console.ReadLine();

            if (metricToConvertFrom == "mm")
            {
                number /= 1000;
            }
            else if (metricToConvertFrom == "cm")
            {
                number /= 100;
            }
            else if (metricToConvertFrom == "mi")
            {
                number /= 0.000621371192;
            }
            else if (metricToConvertFrom == "in")
            {
                number /= 39.3700787;
            }
            else if (metricToConvertFrom == "km")
            {
                number /= 0.001;
            }
            else if (metricToConvertFrom == "ft")
            {
                number /= 3.2808399;
            }
            else if (metricToConvertFrom == "yd")
            {
                number /= 1.0936133;
            }

            if (metricToConvertTo == "mm")
            {
                number *= 1000;
            }
            else if (metricToConvertTo == "cm")
            {
                number *= 100;
            }
            else if (metricToConvertTo == "mi")
            {
                number *= 0.000621371192;
            }
            else if (metricToConvertTo == "in")
            {
                number *= 39.3700787;
            }
            else if (metricToConvertTo == "km")
            {
                number *= 0.001;
            }
            else if (metricToConvertTo == "ft")
            {
                number *= 3.2808399;
            }
            else if (metricToConvertTo == "yd")
            {
                number *= 1.0936133;
            }

            Console.WriteLine($"{number:f8}");

        }
    }
}
