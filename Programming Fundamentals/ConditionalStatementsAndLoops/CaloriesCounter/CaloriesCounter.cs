using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            var numberOfIngredients = int.Parse(Console.ReadLine());
            int totalCalories = 0;
            string ingredient = string.Empty;

            for (int i = 0; i < numberOfIngredients; i++)
            {
                ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese": totalCalories += 500; break;
                    case "tomato sauce": totalCalories += 150; break;
                    case "salami": totalCalories += 600; break;
                    case "pepper": totalCalories += 50; break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
