using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workersOfftime = int.Parse(Console.ReadLine());
            double workHours;
            int offtimeWorkHours;
            double sumHours;
            //Calculations
            workHours = 6.3 * 8;
            offtimeWorkHours = workersOfftime * (2 * 7);
            sumHours = workHours + offtimeWorkHours;

            if (sumHours < hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.", hoursNeeded - sumHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{} hours needed.", sumHours - hoursNeeded);
            }
        }
    }
}
