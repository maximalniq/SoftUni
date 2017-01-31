using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class HexadecimalFormat
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexadecimal, 16));
            
        }
    }
}
