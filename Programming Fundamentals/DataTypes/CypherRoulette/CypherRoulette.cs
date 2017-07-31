using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherRoulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            var stringsQuantity = int.Parse(Console.ReadLine());
            bool whriteInFront = true;
            string previousWord = String.Empty;
            string stringResult = String.Empty;

            for (int i = 0; i < stringsQuantity; i++)
            {
                string currentWord = Console.ReadLine();
                if (currentWord == "spin")
                {
                    whriteInFront = !whriteInFront;
                    i--;
                }
                switch (whriteInFront)
                {
                    case (true): stringResult += currentWord; break;
                    case (false): stringResult = currentWord + stringResult; break;
                }
                if (currentWord == previousWord)
                {
                    stringResult = String.Empty;
                    if (currentWord == "spin")
                    {
                        whriteInFront = !whriteInFront;
                    }
                    previousWord = currentWord;
                }
                previousWord = currentWord;
            }
            stringResult = stringResult.Replace("spin", String.Empty);
            Console.WriteLine(stringResult);
        }
    }
}
