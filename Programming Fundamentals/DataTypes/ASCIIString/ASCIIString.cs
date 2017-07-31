using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIString
{
    class ASCIIString
    {
        static void Main(string[] args)
        {
            int charQuantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < charQuantity; i++)
            {
                int numToChar = int.Parse(Console.ReadLine());
                var letter = (char)(numToChar);
                Console.Write(letter);
            }
        }
    }
}
