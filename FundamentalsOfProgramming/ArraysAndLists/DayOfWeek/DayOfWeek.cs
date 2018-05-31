using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var daysOfWeek = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            var numberOfDay = int.Parse(Console.ReadLine());

            if (numberOfDay == 1)
            {
                Console.WriteLine(daysOfWeek[0]);
            }
            else if (numberOfDay == 2)
            {
                Console.WriteLine(daysOfWeek[1]);
            }
            else if (numberOfDay == 3)
            {
                Console.WriteLine(daysOfWeek[2]);
            }
            else if (numberOfDay == 4)
            {
                Console.WriteLine(daysOfWeek[3]);
            }
            else if (numberOfDay == 5)
            {
                Console.WriteLine(daysOfWeek[4]);
            }
            else if (numberOfDay == 6)
            {
                Console.WriteLine(daysOfWeek[5]);
            }
            else if (numberOfDay == 7)
            {
                Console.WriteLine(daysOfWeek[6]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
