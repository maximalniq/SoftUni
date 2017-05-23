using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str.ToCharArray();

            var arrOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (arrOfNumbers[i] % 2 == 0)
                {
                    result += (char)(str[i] - arrOfNumbers[i]);
                }
                else
                {
                    result += (char)(str[i] + arrOfNumbers[i]);
                }
            }

                Console.WriteLine(result);
        }
    }
}
