using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (product == "coffee")
            {
                if (town == "Sofia")
                {
                    price = 0.50;
                }
                else if (town == "Plovdiv")
                {
                    price = 0.40;
                }
                else if (town == "Varna")
                {
                    price = 0.45;
                }
            }
            if (product == "water")
            {
                if (town == "Sofia")
                {
                    price = 0.80;
                }
                else if (town == "Plovdiv")
                {
                    price = 0.70;
                }
                else if (town == "Varna")
                {
                    price = 0.70;
                }
            }
            if (product == "beer")
            {
                if (town == "Sofia")
                {
                    price = 1.20;
                }
                else if (town == "Plovdiv")
                {
                    price = 1.15;
                }
                else if (town == "Varna")
                {
                    price = 1.10;
                }
            }
            if (product == "peanuts")
            {
                if (town == "Sofia")
                {
                    price = 1.60;
                }
                else if (town == "Plovdiv")
                {
                    price = 1.50;
                }
                else if (town == "Varna")
                {
                    price = 1.55;
                }
            }
            if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    price = 1.45;
                }
                else if (town == "Plovdiv")
                {
                    price = 1.30;
                }
                else if (town == "Varna")
                {
                    price = 1.35;
                }
            }
            Console.WriteLine(price * quantity);
        }
    }
}
