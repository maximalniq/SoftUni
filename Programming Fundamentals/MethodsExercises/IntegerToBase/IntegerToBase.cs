using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToBase
{
    class IntegerToBase
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            string output = _IntegerToBase(number, toBase);
            Console.WriteLine(output);
        }

        static string _IntegerToBase(int number, int toBase)
        {
            string result = string.Empty;

            while (number > 0)
            {

                int numb = number % toBase;

                number /= toBase;
                result = numb.ToString() + result;
            }
            return result;
        }
    }
}
