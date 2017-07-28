using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauarantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            string hall = string.Empty;
            int priceOfHall = 0;

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                priceOfHall = 2500;
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                priceOfHall = 5000;
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                priceOfHall = 7500;
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropiate hall.");
                return;
            }
            Console.WriteLine($"We can offer you the {hall}");

            string typeOfPackage = Console.ReadLine();
            double discount = 0;
            int price = 0;
            

            if (typeOfPackage == "Normal")
            {
                discount = 0.95;
                price = 500;
            }
            else if (typeOfPackage == "Gold")
            {
                discount = 0.90;
                price = 750;
            }
            else if (typeOfPackage == "Platinum")
            {
                discount = 0.85;
                price = 1000;
            }

            Console.WriteLine($"The price per person is {((priceOfHall + price) * discount)/groupSize:f2}$");

        }
    }
}
