using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < s.Length ; i++)
            {
                if (s[i] == 'a')
                {
                    result += 1;
                }
                else if (s[i] == 'e')
                {
                    result += 2;
                }
                else if (s[i] == 'i')
                {
                    result += 3;
                }
                else if (s[i] == 'o')
                {
                    result += 4;
                }
                else if (s[i] == 'u')
                {
                    result += 5;
                }
            }

            Console.WriteLine(result);
        }
    }
}
