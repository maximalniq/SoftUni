using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Score: ");                           //175
            int score = int.Parse(Console.ReadLine());
            if (score <= 100) // bonus = 5t.
            {
                if (score % 2 == 0) // bonus +1
                {
                    Console.WriteLine("Bonus score: 6");
                    Console.WriteLine("Total score: " + (score + 6));
                }
                else if (score % 5 == 0 && score % 10 != 0) // bonus +2
                {
                    Console.WriteLine("Bonus score: 7");
                    Console.WriteLine("Total score: " + (score + 7));
                }
                else
                {
                    Console.WriteLine("Bonus score: 5");
                    Console.WriteLine($"Total score: " + (score + 5));
                }

            }
            else if (score > 100 && score <= 1000) // 20% от точките            35
            {
                double firstBonus = score * 0.2;

                if (score % 2 == 0) // bonus +1            
                {
                    firstBonus = firstBonus + 1;
                    Console.WriteLine($"Bonus score: " + firstBonus);
                    Console.WriteLine($"Total score: " + (firstBonus + score));
                }
                else if (score % 5 == 0 && score % 10 != 0) // bonus +2       37
                {
                    firstBonus = firstBonus + 2;
                    Console.WriteLine($"Bonus score: " + firstBonus);
                    Console.WriteLine($"Total score: " + (firstBonus + score));
                }
                else
                {
                    Console.WriteLine($"Bonus score: " + firstBonus);
                    Console.WriteLine($"Total score: " + (score + firstBonus));
                }
            }
            else // 10% от точките
            {
                double secondBonus = score * 0.1;

                if (score % 2 == 0) // bonus +1
                {
                    secondBonus = secondBonus + 1;
                    Console.WriteLine($"Bonus score: " + secondBonus);
                    Console.WriteLine($"Total score: " + (secondBonus + score));
                }
                else if (score % 5 == 0 && score % 10 != 0) // bonus +2
                {
                    secondBonus = secondBonus + 2;
                    Console.WriteLine($"Bonus score: " + secondBonus);
                    Console.WriteLine($"Total score: " + (secondBonus + score));
                }
                else
                {
                    Console.WriteLine($"Bonus score: " + secondBonus);
                    Console.WriteLine($"Total score: " + (score + secondBonus));
                }

            }
        }
    }
}
