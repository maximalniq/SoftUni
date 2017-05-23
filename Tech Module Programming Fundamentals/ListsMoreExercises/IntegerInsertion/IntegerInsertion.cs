using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var stringList = new List<string>();
            string numberToAddToStringList = string.Empty;

            while (numberToAddToStringList != "end")
            {
                numberToAddToStringList = Console.ReadLine();

                if (numberToAddToStringList == "end")
                {
                    break;
                }
                stringList.Add(numberToAddToStringList);
            }

            for (int i = 0; i < stringList.Count(); i++)
            {
                int phNumber = int.Parse(stringList[i]);
                int firstDigitOfNumber = phNumber;

                if (phNumber > 10)
                {
                    while (phNumber >= 10)
                    {
                        phNumber /= 10;
                        firstDigitOfNumber = phNumber;
                    }
                }

                list.Insert(firstDigitOfNumber, int.Parse(stringList[i]));
            }

            foreach (var number in list)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
