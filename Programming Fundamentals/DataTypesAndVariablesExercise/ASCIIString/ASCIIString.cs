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
            var n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                var ASCIINumber = int.Parse(Console.ReadLine());
                char c1 = (char)ASCIINumber;
                result += c1;
            }
            Console.WriteLine(result);
        }
    }
}
