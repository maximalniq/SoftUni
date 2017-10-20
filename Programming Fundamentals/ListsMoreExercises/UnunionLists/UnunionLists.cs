using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            var listOfNumbrs = Console.ReadLine().Split().Select(int.Parse).ToList();

            var numberOfTempLists = int.Parse(Console.ReadLine());

            var tempList = new List<int>();

            for (int i = 0; i < numberOfTempLists; i++)
            {
                tempList = Console.ReadLine().Split().Select(int.Parse).ToList();

                var removeFromPrimalList = listOfNumbrs.Except(tempList).ToList();
                var addToPrimalList = tempList.Except(listOfNumbrs).ToList();

                var conjunctiveList = removeFromPrimalList.Union(addToPrimalList).ToList();

                listOfNumbrs = conjunctiveList.ToList();
            }
            var listToPrint = listOfNumbrs.OrderBy(x => x).ToList();
            Console.WriteLine($"{string.Join(" ", listToPrint)}");

        }
    }
}
