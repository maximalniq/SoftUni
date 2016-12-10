using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double bonusPoints = 0;

            var points = double.Parse(Console.ReadLine());

            if (points <= 100)
            {
                bonusPoints += 5;
            }
            if (points > 100 && points < 1000)
            {
                bonusPoints = points * 20 / 100;
            }
            if (points > 1000)
            {
                bonusPoints = points * 10 / 100;
            }
            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }
            if (points % 10 == 5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);
        }
    }
}
