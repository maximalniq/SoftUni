using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementsEqualtoTheirIndex
{
    class ElementsEqualToTheirIndex
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string elementsEqualToTheirIndex = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i)
                {
                    elementsEqualToTheirIndex += arr[i] + " ";
                }
            }

            Console.WriteLine(elementsEqualToTheirIndex);
        }
    }
}
