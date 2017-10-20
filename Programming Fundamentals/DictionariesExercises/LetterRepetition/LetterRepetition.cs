using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dictionory = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!dictionory.ContainsKey(letter))
                {
                    dictionory.Add(letter, 1);
                }
                else
                {
                    dictionory[letter] += 1;
                }
            }

            foreach (var kvp in dictionory)
            {

                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
