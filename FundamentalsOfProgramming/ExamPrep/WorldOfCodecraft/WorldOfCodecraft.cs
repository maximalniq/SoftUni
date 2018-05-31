using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfCodecraft
{
    class WorldOfCodecraft
    {
        static void Main(string[] args)
        {
            double day1 = double.Parse(Console.ReadLine());
            double day2 = double.Parse(Console.ReadLine());
            double day3 = double.Parse(Console.ReadLine());
            double day4 = double.Parse(Console.ReadLine());
            double day5 = double.Parse(Console.ReadLine());
            double day6 = double.Parse(Console.ReadLine());
            double day7 = double.Parse(Console.ReadLine());
            double day8 = double.Parse(Console.ReadLine());
            double day9 = double.Parse(Console.ReadLine());
            double day10 = double.Parse(Console.ReadLine());

            var tenDays = new double[] {day1, day2, day3, day4, day5, day6, day7, day8, day9, day10 };
            double minimumTemperatureDay = 100;
            double maximumTemperatureDay = 0;
            int daysBelowZeroCounter = 0;

            foreach (var day in tenDays)
            {
                if (day > maximumTemperatureDay)
                {
                    maximumTemperatureDay = day;
                }

                if (day < minimumTemperatureDay)
                {
                    minimumTemperatureDay = day;
                }

                if (day < 0)
                {
                    daysBelowZeroCounter++;
                }
            }

            if (minimumTemperatureDay >= -10 && daysBelowZeroCounter < 5 && maximumTemperatureDay < 45)
            {
                Console.WriteLine($"The lowest temperature is {minimumTemperatureDay:f1} degrees. The coders are off to battle!");
            }
            else
            {
                Console.WriteLine($"The lowest temperature is {minimumTemperatureDay:f1} degrees. The coders rest.");
            }


        }
    }
}
