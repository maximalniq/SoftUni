using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var sortedPhonebook = new SortedDictionary<string, long>();

            while (input[0] != "Over")
            {
                long number;
                bool parsed = long.TryParse(input[1], out number);

                if (parsed)
                {
                    sortedPhonebook.Add(input[0], number);
                }
                else
                {
                    int numberReversed = Int32.Parse(input[0]);
                    sortedPhonebook.Add(input[1], numberReversed);
                }


                 input = Console.ReadLine()
                .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var kvp in sortedPhonebook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
