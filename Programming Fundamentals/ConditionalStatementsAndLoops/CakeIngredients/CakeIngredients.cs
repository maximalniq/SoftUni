using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string ingredient = string.Empty;
            int numberOfIngredients = 0;

            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}");
                    numberOfIngredients++;
                }          
            }
            Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
        }
    }
}
