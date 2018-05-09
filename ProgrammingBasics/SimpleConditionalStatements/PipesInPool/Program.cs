using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());

            var calculation = (H * P1) + (H * P2);
            var percentFool = calculation / V * 100;
            var P1percentFool =Math.Truncate((H * P1) / calculation * 100) ;
            var P2percentFool =Math.Truncate((H * P2) / calculation * 100);

            if (V > calculation)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",percentFool ,P1percentFool, P2percentFool );
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",H ,calculation - V);
            }
        }
    }
}
