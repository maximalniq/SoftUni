using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < listOfNumbers.Count(); i++)
            {
                if (!dictionary.ContainsKey(listOfNumbers[i]))
                {
                    int currentNumber = listOfNumbers[i];
                    int counterOfCurrentNumber = 0;
                    for (int j = 0; j < listOfNumbers.Count(); j++)
                    {
                        if (listOfNumbers[i] == listOfNumbers[j])
                        {
                            counterOfCurrentNumber++;
                        }
                    }
                    dictionary.Add(listOfNumbers[i], counterOfCurrentNumber);
                }
            }

            var max = dictionary.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            Console.WriteLine(max);
        }
    }
}
