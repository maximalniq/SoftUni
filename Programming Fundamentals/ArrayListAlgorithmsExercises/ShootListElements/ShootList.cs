using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElements
{
    class ShootList
    {
        static void Main(string[] args)
        {
            var shootList = new List<int>();
            string input = Console.ReadLine();
            int numberToShoot = 0;
            int lastShotNumber = 0;

            while (input != "stop")
            {
                if (input != "bang")
                {
                    int number = int.Parse(input);
                    shootList.Insert(0, number);
                }
                else if (input == "bang")
                {
                    
                    if (shootList.Count() > 1)
                    {
                        for (int i = 0; i < shootList.Count(); i++)
                        {
                            if (shootList[i] < shootList.Average())
                            {
                                numberToShoot = shootList[i];
                                shootList.Remove(numberToShoot);
                                Console.WriteLine($"shot {numberToShoot}");
                                for (int j = 0; j < shootList.Count(); j++)
                                {
                                    shootList[j] -= 1;
                                }
                                break;
                            }
                        }
                    }
                    else if (shootList.Count() == 1)
                    {
                        lastShotNumber = shootList[0];
                        shootList.Remove(shootList[0]);
                        Console.WriteLine($"shot {lastShotNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {numberToShoot}");
                        return;
                    }
                }
                input = Console.ReadLine();
            }

            if (shootList.Count() > 0)
            {
                Console.WriteLine($"survivors: {(string.Join(" ", shootList))}");
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastShotNumber}");
            }
        }
    }
}
