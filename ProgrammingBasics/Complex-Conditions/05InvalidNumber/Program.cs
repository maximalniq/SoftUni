using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number < 100 && number != 0)
            {
                Console.WriteLine("invalid");
            }
            else if (number > 200 && number != 0)
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
