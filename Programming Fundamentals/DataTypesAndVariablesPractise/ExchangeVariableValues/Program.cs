using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            int c = 0;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", b);
            Console.WriteLine("b = {0}", a);
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            
        }
    }
}
