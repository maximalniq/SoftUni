using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            double taxiStartPrice = 0.70;
            double taxiDayPrice = taxiStartPrice + (0.79 * n);
            double taxiNightPrice = taxiStartPrice + (0.90 * n);
            double busPrice = 0.09 * n;
            double trainPrice = 0.06 * n;

            if (n < 20 && dayTime == "day")
            {
                Console.WriteLine(taxiDayPrice);
            }
            else if (n < 20 && dayTime == "night")
            {
                Console.WriteLine(taxiNightPrice);
            }
            if (n >= 20 && n < 100)
            {
                Console.WriteLine(busPrice);
            }
            else if (n >= 100)
            {
                Console.WriteLine(trainPrice);
            }
        }
    }
}
