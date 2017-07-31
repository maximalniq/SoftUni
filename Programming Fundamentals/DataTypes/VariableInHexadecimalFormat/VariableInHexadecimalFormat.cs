using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();

            int num = Convert.ToInt32(hexNum, 16);

            Console.WriteLine(num);
        }
    }
}
