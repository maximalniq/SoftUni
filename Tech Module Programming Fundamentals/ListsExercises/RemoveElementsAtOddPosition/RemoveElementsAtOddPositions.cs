using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListOfStrings = Console.ReadLine()
                .Split(' ');
            var ResultList = new List<string>();

            for (int i = 1; i <= ListOfStrings.Count(); i++)
            {
                if (i % 2 == 0)
                {
                    ResultList.Add(ListOfStrings[i - 1]);
                }

            }

            for (int i = 0; i < ResultList.Count(); i++)
            {
                Console.Write(ResultList[i]);
            }
        }
    }
}
