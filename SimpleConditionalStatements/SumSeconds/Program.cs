using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            int seconds = first + second + third;
            int minutes = 0;

            if (seconds > 0 && seconds < 60)
            {
                minutes = 0;
                if (seconds > 0 && seconds < 10)
                {
                    Console.WriteLine("{0}:0{1}", minutes, seconds);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", minutes, seconds);
                }
                
            }
            else if (seconds >= 60 && seconds < 120 )
            {
                minutes = 1;
                seconds -= 60;
                if (seconds >= 0 && seconds < 10)
                {
                    Console.WriteLine("{0}:0{1}", minutes, seconds);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", minutes, seconds);
                }
                
            }
            else if (seconds >= 120 && seconds < 180)
            {
                minutes = 2;
                seconds -= 120;
                if (seconds > 0 && seconds < 10)
                {
                    Console.WriteLine("{0}:0{1}", minutes, seconds);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", minutes, seconds);
                }
            }
            
        }
    }
}
