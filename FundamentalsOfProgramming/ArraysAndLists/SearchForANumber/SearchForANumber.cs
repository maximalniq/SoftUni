using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var manipulatorArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> resultList = new List<int>();

            for (int i = 0; i < manipulatorArray[0]; i++)
            {
                resultList.Add(inputList[i]);
            }

            for (int i = 0; i < manipulatorArray[1]; i++)
            {
                resultList.RemoveAt(0);
            }

            if (resultList.Contains(manipulatorArray[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
