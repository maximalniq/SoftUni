using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string secondName = Console.ReadLine();
            PrintName(secondName);
        }

        static string PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return name;
        }
    }
}
