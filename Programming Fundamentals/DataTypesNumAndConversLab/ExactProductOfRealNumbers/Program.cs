using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactProductOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal product = 1.0m;
            for (int i = 0; i < n; i++)
            {
                var number = decimal.Parse(Console.ReadLine());
                product *= number;
            }
            Console.WriteLine(product);
        }
    }
}
