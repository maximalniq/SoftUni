using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            string leaveTime = Console.ReadLine();

            DateTime leaveTimeFormatted = DateTime.ParseExact(leaveTime, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            int numberOfSteps = int.Parse(Console.ReadLine());

            int timeInSeconds = int.Parse(Console.ReadLine());

            string resultTime = leaveTimeFormatted.AddSeconds(numberOfSteps * timeInSeconds).ToString("HH:mm:ss");

            Console.WriteLine("Time Arrival: {0}", resultTime);
        }
    }
}
