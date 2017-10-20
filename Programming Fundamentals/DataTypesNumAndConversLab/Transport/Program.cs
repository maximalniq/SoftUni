using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = int.Parse(Console.ReadLine());
            int result = persons / 24;

            if (24 % persons != 0 )
            {
                result += 1;
            }

            Console.WriteLine(result);
        }
    }
}
