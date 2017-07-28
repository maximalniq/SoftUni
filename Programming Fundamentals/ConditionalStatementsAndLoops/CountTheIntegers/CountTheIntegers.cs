using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int countOfNumbers = 0;

            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());
                    countOfNumbers++;
                }
                
            }
            catch (FormatException)
            {

                Console.WriteLine(countOfNumbers);
            }
        }
    }
}
