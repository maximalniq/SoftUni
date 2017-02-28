using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvarageCharacterDelimeter
{
    class AvarageCharacterDelimeter
    {
        static void Main(string[] args)
        {
            var arrayOfStrings = Console.ReadLine().Split().ToArray();
            int sum = 0;
            char avarageLetter = ' ';
            int letterCounter = 0;

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                foreach (char letter in arrayOfStrings[i])
                {
                    sum += (int)letter;
                    letterCounter++;
                }
            }

            avarageLetter = (char)(sum / letterCounter);
            avarageLetter = Char.ToUpper(avarageLetter);

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                if (i == arrayOfStrings.Length - 1)
                {
                    Console.Write($"{arrayOfStrings[i]}");
                }
                else
                {
                    Console.Write($"{arrayOfStrings[i]}{avarageLetter}");
                }
            }
            

        }
    }
}
