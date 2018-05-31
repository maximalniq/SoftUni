using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var sumArray = new long[n];
            sumArray[0] = 1;

            var start = 0;

                for (int i = 1; i < n; i++)     
                {
                    if (i >= k)
                    {
                        start = i - k;
                    }

                    for (int j = start; j <= i - 1; j++)
                    {
                        sumArray[i] += sumArray[j];
                    }
                }
                Console.WriteLine(string.Join(" ", sumArray));

        }
    }
}
