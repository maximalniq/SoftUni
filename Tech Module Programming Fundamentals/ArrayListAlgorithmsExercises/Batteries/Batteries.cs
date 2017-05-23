using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            var batteriesCapacity = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            var usagePerHour = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            int amountOfHours = int.Parse(Console.ReadLine());
            var resultAarray = new double[batteriesCapacity.Length];
            int hoursUntillDead = 0;

            for (int i = 0; i < batteriesCapacity.Length; i++)
            {
                while (hoursUntillDead < amountOfHours)
                {
                    hoursUntillDead++;
                    resultAarray[i] = batteriesCapacity[i] - usagePerHour[i] * hoursUntillDead;
                    if (resultAarray[i] < 0)
                    {
                        break;
                    }
                }
                double percentageOfRemainingBattery = resultAarray[i] / batteriesCapacity[i] * 100f;
                if (resultAarray[i] > 0)
                {
                    Console.WriteLine($"Battery {i + 1}: {resultAarray[i]:f2} mAh ({percentageOfRemainingBattery:f2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {hoursUntillDead} hours)");
                }
                hoursUntillDead = 0;
            }


        }
    }
}
