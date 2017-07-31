using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            int ph = 0;

            ph = a;
            a = b;
            b = ph;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
