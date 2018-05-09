using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity * 2.50:f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity * 1.20:f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity * 0.85:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.45:f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity * 2.70:f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.50:f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity * 3.85:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity * 2.70:f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity * 1.25:f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity * 0.90:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.60:f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity * 3.00:f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.60:f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity * 4.20:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}
