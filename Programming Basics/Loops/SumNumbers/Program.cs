using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                var sum = int.Parse(Console.ReadLine());
                result += sum;
            }
            Console.WriteLine(result);
        }
    }
}
