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
            var miles = decimal.Parse(Console.ReadLine());
            decimal kilometers = Decimal.Multiply(miles, (decimal)1.60934);

            Console.WriteLine("{0:f2}", kilometers);


        }
    }
}
