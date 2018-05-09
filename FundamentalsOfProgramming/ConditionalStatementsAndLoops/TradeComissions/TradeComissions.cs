using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            var volume = double.Parse(Console.ReadLine());

            double commission = 0;

            if (town == "sofia")
            {
                if (volume <= 500 && volume >= 0)
                {
                    commission = 5;
                }
                if (volume <= 1000 && volume > 500)
                {
                    commission = 7;
                }
                if (volume <= 10000 && volume > 1000)
                {
                    commission = 8;
                }
                if (volume > 10000)
                {
                    commission = 12;
                }
            }
            else if (town == "varna")
            {
                if (volume <= 500 && volume >= 0)
                {
                    commission = 4.5;
                }
                if (volume <= 1000 && volume > 500)
                {
                    commission = 7.5;
                }
                if (volume <= 10000 && volume > 1000)
                {
                    commission = 10;
                }
                if (volume > 10000)
                {
                    commission = 13;
                }
            }
            else if (town == "plovdiv")
            {
                if (volume <= 500 && volume >= 0)
                {
                    commission = 5.5;
                }
                if (volume <= 1000 && volume > 500)
                {
                    commission = 8;
                }
                if (volume <= 10000 && volume > 1000)
                {
                    commission = 12;
                }
                if (volume > 10000)
                {
                    commission = 14.5;
                }
            }

            if (commission <= 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{commission / 100 * volume:f2}");
            }
            
        }
    }
}
