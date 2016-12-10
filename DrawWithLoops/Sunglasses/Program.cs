using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //TOP
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            //MID
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                Console.Write("/", (2 * n) - 2);
                Console.Write("*");
                Console.Write(" ", n);
                Console.Write("*");
                Console.Write("/", (2 * n) - 2);
                Console.Write("*");
                Console.WriteLine();
            }
            //BOT
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
