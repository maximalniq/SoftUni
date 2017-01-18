using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            int weekendsInSofia;
            double playedGamesInSofia;
            int playedGamesInHomeTown;
            double playedGamesInHolidays;
            double sumGames;
            double result;

            //Calculations
            weekendsInSofia = 48 - h;
            playedGamesInSofia = weekendsInSofia * 3.0 / 4;
            playedGamesInHomeTown = h;
            playedGamesInHolidays = p * 2.0 / 3;
            sumGames = playedGamesInHolidays + playedGamesInHomeTown + playedGamesInSofia;

            if (year == "leap")
            {
                result = sumGames + (15.0 / 100 * sumGames);
            }
            else
            {
                result = sumGames;
            }

            Console.WriteLine(Math.Truncate(result));
        }
    }
}
