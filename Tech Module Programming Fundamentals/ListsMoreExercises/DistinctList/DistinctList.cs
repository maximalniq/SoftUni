using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            var List = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> distinctList = List.Distinct().ToList();

            foreach (var number in distinctList)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
