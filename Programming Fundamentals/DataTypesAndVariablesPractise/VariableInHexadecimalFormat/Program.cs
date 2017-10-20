using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nereshena
            string a = Console.ReadLine();
            Convert.ToInt32(a, 16);
            Console.WriteLine(a);
        }
    }
}
