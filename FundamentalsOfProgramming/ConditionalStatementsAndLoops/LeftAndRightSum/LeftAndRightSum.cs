using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            int sumOfFirstNumber = 0;
            int sumOfSecondNumbers = 0;

            for (int i = 0; i < counter; i++)
            {
                var numberToRead = int.Parse(Console.ReadLine());
                sumOfFirstNumber += numberToRead;
            }

            for (int i = 0; i < counter; i++)
            {
                var numberToRead = int.Parse(Console.ReadLine());
                sumOfSecondNumbers += numberToRead;
            }

            int abs = Math.Abs(sumOfFirstNumber - sumOfSecondNumbers);

            if (abs == 0)
            {
                Console.WriteLine($"Yes, sum = {sumOfFirstNumber}");
            }
            else
            {
                int biggerNumber = 0;
                if (sumOfFirstNumber > sumOfSecondNumbers)
                {
                    biggerNumber = sumOfFirstNumber;
                }
                else
                {
                    biggerNumber = sumOfSecondNumbers;
                }
                Console.WriteLine($"No, diff = {biggerNumber -(biggerNumber - Math.Abs(sumOfFirstNumber - sumOfSecondNumbers))}");
            }
        }
    }
}
