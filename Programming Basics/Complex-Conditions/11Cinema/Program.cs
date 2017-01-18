using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var redove = int.Parse(Console.ReadLine());
            var koloni = int.Parse(Console.ReadLine());
            double price = 0;

            if (type == "Premiere")
            {
                price = 12.00;
            }
            else if (type == "Normal")
            {
                price = 7.50;
            }
            else if (type == "Discount")
            {
                price = 5.00;
            }

            Console.WriteLine("{0:f2} leva", ( (redove * koloni) * price) );
        }
    }
}
