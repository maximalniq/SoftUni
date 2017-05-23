using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            var arrayOfWords = Console.ReadLine().Split().ToArray();
            var listOfWords = new List<string>();
            var occurrencesCount = new List<int>();
            bool swapped;

            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                if (!listOfWords.Contains(arrayOfWords[i]))
                {
                    listOfWords.Add(arrayOfWords[i]);
                    occurrencesCount.Add(1);
                }
                else
                {
                    int index = listOfWords.FindIndex(x => x==arrayOfWords[i]);
                    occurrencesCount[index] += 1;
                }
            }

            do
            {
                swapped = false;
                for (int i = 0; i < occurrencesCount.Count() - 1; i++)
                {
                    if (occurrencesCount[i] < occurrencesCount[i + 1])
                    {
                        int occurencesTemp = occurrencesCount[i];
                        occurrencesCount[i] = occurrencesCount[i + 1];
                        occurrencesCount[i + 1] = occurencesTemp;

                        string wordPh = listOfWords[i];
                        listOfWords[i] = listOfWords[i + 1];
                        listOfWords[i + 1] = wordPh;

                        swapped = true;
                    }
                }
            } while (swapped);

            int sumOfOccurrences = occurrencesCount.Sum();

            for (int i = 0; i < listOfWords.Count(); i++)
            {
                Console.WriteLine($"{listOfWords[i]} -> {occurrencesCount[i]} times ({(double)((double)occurrencesCount[i] / (double)sumOfOccurrences * 100f):f2}%)");
            }
        }
    }
}
