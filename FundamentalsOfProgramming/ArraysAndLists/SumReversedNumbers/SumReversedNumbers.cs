using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ReverseDigits(arr);

            Console.WriteLine(arr.Sum());
        }

        private static void ReverseDigits(int[] arr)
        {
            int reversed = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] > 0)
                {
                    reversed = reversed * 10 + arr[i] % 10;
                    arr[i] = arr[i] / 10;

                }

                arr[i] = reversed;
                reversed = 0;
            }
        }
      }
    }
