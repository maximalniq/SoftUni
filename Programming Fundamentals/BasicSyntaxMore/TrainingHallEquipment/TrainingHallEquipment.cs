using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var numberOfItems = int.Parse(Console.ReadLine());

            var subTotalSum = 0d;

            for (int i = 0; i < numberOfItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPricer = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                subTotalSum += (itemPricer * itemCount);
                if (itemCount == 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }

            }
            var moneyLeft = budget - subTotalSum;

            Console.WriteLine($"Subtotal: ${subTotalSum:f2}");
            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(moneyLeft):f2} more.");
            }
        }
    }
}
