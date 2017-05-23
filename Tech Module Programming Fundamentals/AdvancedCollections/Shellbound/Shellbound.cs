using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();

            var crabData = new Dictionary<string, HashSet<int>>();

            while (input[0] != "Aggregate")
            {
                int number = int.Parse(input[1]);

                if (crabData.ContainsKey(input[0]))
                {
                    crabData[input[0]].Add(number);
                }
                else
                {
                    crabData[input[0]] = new HashSet<int>();
                    crabData[input[0]].Add(number);
                }

                input = Console.ReadLine()
                .Split()
                .ToArray();
            }

            foreach (var kvp in crabData)
            {

                Console.WriteLine("{0} -> {1} ({2})" , kvp.Key, string.Join(", ", kvp.Value ),
                    (kvp.Value.Sum() - (kvp.Value.Sum() / kvp.Value.Count() )));
            }
        }
    }
}
