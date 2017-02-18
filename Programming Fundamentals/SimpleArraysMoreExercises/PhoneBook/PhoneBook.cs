using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        static void Main(string[] args)
        {
            string[] arrOfNumbers = Console.ReadLine()
                .Split(' ');

            string[] arrOfNames = Console.ReadLine()
                .Split(' ');

            string printName = string.Empty;

            while (printName != "done")
            {
                printName = Console.ReadLine();

                for (int i = 0; i < arrOfNames.Length; i++)
                {
                    if (printName == arrOfNames[i])
                    {
                        Console.WriteLine($"{arrOfNames[i]} -> {arrOfNumbers[i]}");
                    }
                }
            }

            
        }
    }
}
