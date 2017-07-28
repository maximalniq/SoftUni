using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            var nightCounts = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;
            double totalStudioPrice = 0.0;
            double totalDoublePrice = 0.0;
            double suiteTotalPrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (nightCounts > 7)
                {
                    studioPrice *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;

                if (nightCounts > 14)
                {
                    doublePrice *= 0.90;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nightCounts > 14)
                {
                    suitePrice *= 0.85;
                }
            }

            totalStudioPrice = studioPrice * nightCounts;
            totalDoublePrice = doublePrice * nightCounts;
            suiteTotalPrice = suitePrice * nightCounts;

            if (nightCounts > 7 && (month == "September" || month == "October"))
            {
                totalStudioPrice -= studioPrice;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suiteTotalPrice:f2} lv.");
        }
    }
}
