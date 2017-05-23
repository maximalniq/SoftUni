using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfStrings
{
    class SortArray
    {
        static void Main(string[] args)
        {
            var arrToSort = Console.ReadLine().Split().ToArray();
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 0; i < arrToSort.Length - 1; i++)
                {
                    if (arrToSort[i + 1].CompareTo(arrToSort[i]) < 0)
                    {
                        string temp = arrToSort[i + 1];
                        arrToSort[i + 1] = arrToSort[i];
                        arrToSort[i] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine($"{string.Join(" ", arrToSort)}");

        }
    }
}
