using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaPrecision12
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;

            Console.WriteLine("{0:f12}", area);
        }
    }
}
