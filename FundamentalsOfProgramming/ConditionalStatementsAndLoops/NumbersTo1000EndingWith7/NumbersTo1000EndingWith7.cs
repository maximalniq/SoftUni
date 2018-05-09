using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersTo1000EndingWith7
{
    class NumbersTo1000EndingWith7
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
