using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelsBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var M = int.Parse(Console.ReadLine());
            int roundsCount = 0;

            if (M == list.Count())
            {
                Console.Write("already stable: ");
                foreach (var number in list)
                {
                    Console.Write($"{number} ");
                }
            }
            else
            {
                while (M != list.Count())
                {
                    list.Remove(list[0]);
                    list.Remove(list[list.Count() - 1]);
                    roundsCount++;
                }
                Console.WriteLine($"{roundsCount} rounds");
                Console.Write("remaining: ");
                foreach (var number in list)
                {
                    Console.Write($"{number} ");
                }
            }

        }
    }
}
