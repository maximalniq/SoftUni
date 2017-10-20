using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            var N = int.Parse(Console.ReadLine());

            RepeatString(symbol, N);
        }

        private static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                Console.Write(str);
            }
            return str;
        }
    }
}
