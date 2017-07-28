using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            var miles = float.Parse(Console.ReadLine());
            float kilometers = miles * 1.60934f;

            Console.WriteLine("{0:f2}", kilometers);
        }
    }
}
