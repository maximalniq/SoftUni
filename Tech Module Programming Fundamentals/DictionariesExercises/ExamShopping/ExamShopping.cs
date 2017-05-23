using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();

            var stockedProducts = new SortedDictionary<string, int>();

            while (input[0] != "shopping" && input[1] != "time")
            {
                int quantity = int.Parse(input[2]);

                if (!stockedProducts.ContainsKey(input[1]))
                {
                    stockedProducts[input[1]] = quantity;
                }
                else
                {
                    stockedProducts[input[1]] += quantity;
                }

                input = Console.ReadLine()
                .Split()
                .ToArray();
            }

            input = Console.ReadLine()
                .Split()
                .ToArray();

            while (input[0] != "exam" && input[1] != "time")
            {
                int quantity = int.Parse(input[2]);

                if (stockedProducts.ContainsKey(input[1]))
                {
                    if (stockedProducts[input[1]] < 0)
                    {
                        Console.WriteLine($"{input[1]} out of stock");
                    }
                    else
                    {
                        stockedProducts[input[1]] -= quantity;
                    }
                }
                else
                {
                    Console.WriteLine($"{input[1]} doesn't exist");
                }

                input = Console.ReadLine()
                .Split()
                .ToArray();
            }

            foreach (var kvp in stockedProducts)
            {
                if (kvp.Value <= 0)
                {

                }
                else
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
