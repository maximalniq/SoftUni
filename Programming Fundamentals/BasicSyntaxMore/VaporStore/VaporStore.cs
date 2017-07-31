using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            var currentBalance = float.Parse(Console.ReadLine());
            string input = string.Empty;
            float totalSpent = 0f;

            while (input != "Game Time")
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "OutFall 4":
                        if (currentBalance >= 39.99f)
                        {
                            currentBalance -= 39.99f;
                            totalSpent += 39.99f;
                            Console.WriteLine("Bought OutFall 4");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive"); break;
                        }
                    case "CS: OG":
                        if (currentBalance >= 15.99f)
                        {
                            currentBalance -= 15.99f;
                            totalSpent += 15.99f;
                            Console.WriteLine("Bought CS: OG");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive"); break;
                        }
                    case "Zplinter Zell":
                        if (currentBalance >= 19.99f)
                        {
                            currentBalance -= 19.99f;
                            totalSpent += 19.99f;
                            Console.WriteLine("Bought Zplinter Zell");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive"); break;
                        }
                    case "Honored 2":
                        if (currentBalance >= 59.99f)
                        {
                            currentBalance -= 59.99f;
                            totalSpent += 59.99f;
                            Console.WriteLine("Bought Honored 2");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive"); break;
                        }
                    case "RoverWatch":
                        if (currentBalance >= 29.99f)
                        {
                            currentBalance -= 29.99f;
                            totalSpent += 29.99f;
                            Console.WriteLine("Bought RoverWatch");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive"); break;
                        }
                    case "RoverWatch Origins Edition":
                        if (currentBalance >= 39.99f)
                        {
                            currentBalance -= 39.99f;
                            totalSpent += 39.99f;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive"); break;
                        }

                    default: Console.WriteLine("Not Found"); break;
                }
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
