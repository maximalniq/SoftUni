using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                int a = arrayOfNumbers[i];

                for (int j = 0; j < arrayOfNumbers.Length; j++)
                {
                    if (j > i)
                    {
                        int b = arrayOfNumbers[j];
                        int sum = a + b;

                        if (arrayOfNumbers.Contains(sum))
                        {
                            Console.WriteLine($"{a} + {b} == {sum}");
                        }                        
                    }               
                }
            }
            
        }
    }
}
