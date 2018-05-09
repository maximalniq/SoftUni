using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double OddSum = 0.0;
            double OddMin = 0.0;
            double OddMax = 0.0;
            double EvenSum = 0.0;
            double EvenMax = 0.0;
            double EvenMin = 0;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    OddSum += num;
                    if (i == 0)
                    {
                        OddMax = num;
                        OddMin = num;
                    }
                    if (num > OddMax)
                    {
                        OddMax = num;
                    }

                    if (num < OddMin)
                    {
                        OddMin = num;
                    }
                }
                else
                {
                    EvenSum += num;

                    if (i == 1)
                    {
                        EvenMax = num;
                        EvenMin = num;
                    }
                    if (num > EvenMax)
                    {
                        EvenMax = num;
                    }

                    if (num < EvenMin)
                    {
                        EvenMin = num;
                    }
                }



            }

            Console.WriteLine("OddSum={0}", OddSum);
            if (OddMin == 0)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin={0}", OddMin);
            }
            if (OddMax == 0)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax={0}", OddMax);
            }
            Console.WriteLine("EvenSum={0}", EvenSum);



            if (EvenMin == 0)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0}", EvenMin);
            }
            if (EvenMax == 0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax={0}", EvenMax);
            }
        }
    }
}
