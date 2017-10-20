using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies
{
    class DecodeRadio
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            var listWords = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] freq = input[i].ToString().Split('.');
                int firstPart = Int32.Parse(freq[0]);
                int secondPart = Int32.Parse(freq[1]);

                var firstChar = (char)(firstPart);
                var secondChar = (char)(secondPart);


                if (firstPart != 0)
                {
                    listWords.Insert(i, firstChar);
                }
                if (secondPart != 0)
                {
                    listWords.Insert(listWords.Count - i, secondChar);
                }
            }

            Console.WriteLine(string.Join("", listWords));
        }

    }
}
