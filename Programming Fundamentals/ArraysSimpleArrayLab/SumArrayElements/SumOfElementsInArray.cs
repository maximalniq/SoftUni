using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrayElements
{
    class SumOfElementsInArray
    {
        static void Main(string[] args)
        {
            var numberOfElements = int.Parse(Console.ReadLine());
            var arr = new int[numberOfElements];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                arr[i] = currentNumber;
                sum += arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}
