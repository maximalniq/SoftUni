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
            var N = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < N; i++)
            {
                string randomCharacters = Console.ReadLine();

                if (randomCharacters == "spin")
                {
                    i++;
                }
                else
                {
                    result += randomCharacters;
                }
            }
            Console.WriteLine(result);
        }
    }
}
