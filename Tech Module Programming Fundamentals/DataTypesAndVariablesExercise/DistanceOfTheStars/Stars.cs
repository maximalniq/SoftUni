using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOfTheStars
{
    class Stars
    {
        static void Main(string[] args)
        {
            var distanceFromEarth = 4.22M;
            var distanceToCenter = 26000M;
            var diameter = 100000M;
            var toTheEdge = 46500000000M;
            var oneLightYear = 9450000000000M;

            Console.WriteLine("{0:e2}",distanceFromEarth * oneLightYear);
            Console.WriteLine("{0:e2}", distanceToCenter * oneLightYear);
            Console.WriteLine("{0:e2}",diameter * oneLightYear);
            Console.WriteLine("{0:e2}", toTheEdge * oneLightYear);
        }
    }
}
