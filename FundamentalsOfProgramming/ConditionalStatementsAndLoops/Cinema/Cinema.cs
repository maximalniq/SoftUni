using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var columns = double.Parse(Console.ReadLine());
            var rows = double.Parse(Console.ReadLine());

            double price = 0;

            if (type == "Premiere") price = 12.00;

            else if (type == "Normal") price = 7.50;

            else if (type == "Discount") price = 5.00;

            Console.WriteLine($"{(columns * rows) * (price):f2}");
        }
    }
}
