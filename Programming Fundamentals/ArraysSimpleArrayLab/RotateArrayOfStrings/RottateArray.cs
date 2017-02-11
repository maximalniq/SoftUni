using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfStrings
{
    class RottateArray
    {
        static void Main(string[] args)
        {
            string[] arr =
                Console.ReadLine()
                .Split(' ');

            var result = new string[arr.Length];

            result[0] = arr[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                result[i + 1] = arr[i];
            }

            var resultAsString = string.Join(" ", result);
            Console.WriteLine(resultAsString);
        }
    }
}
