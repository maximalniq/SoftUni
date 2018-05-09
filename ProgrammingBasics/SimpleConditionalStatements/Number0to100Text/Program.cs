using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0to100Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string singleDigit = "";
            string tensDigit = "";
            string teens = "";
            int tens = num / 10;
            int singles = num % 10;

            if (singles == 1)
            {
                singleDigit = "one";
            }
            if (singles == 2)
            {
                singleDigit = "two";
            }
            if (singles == 3)
            {
                singleDigit = "three";
            }
            if (singles == 4)
            {
                singleDigit = "four";
            }
            if (singles == 5)
            {
                singleDigit = "five";
            }
            if (singles == 6)
            {
                singleDigit = "six";
            }
            if (singles == 7)
            {
                singleDigit = "seven";
            }
            if (singles == 8)
            {
                singleDigit = "eight";
            }
            if (singles == 9)
            {
                singleDigit = "nine";
            }
            //tens ifs
            if (tens == 2)
            {
                tensDigit = "twenty";
            }
            if (tens == 3)
            {
                tensDigit = "thirty";
            }
            if (tens == 4)
            {
                tensDigit = "fourty";
            }
            if (tens == 5)
            {
                tensDigit = "fifty";
            }
            if (tens == 6)
            {
                tensDigit = "sixty";
            }
            if (tens == 7)
            {
                tensDigit = "seventy";
            }
            if (tens == 8)
            {
                tensDigit = "eighty";
            }
            if (tens == 9)
            {
                tensDigit = "ninety";
            }
            //11 to 19 ifs
            if (num == 11)
            {
                teens = "eleven"; 
            }
            if (num == 12)
            {
                teens = "twelve";
            }
            if (num == 13)
            {
                teens = "thirteen";
            }
            if (num == 14)
            {
                teens = "fourteen";
            }
            if (num == 15)
            {
                teens = "fifteen";
            }
            if (num == 16)
            {
                teens = "sixteen";
            }
            if (num == 17)
            {
                teens = "seventeen";
            }
            if (num == 18)
            {
                teens = "eighteen";
            }
            if (num == 19)
            {
                teens = "nineteen";
            }

            if (num > 10 && num < 20)
            {
                Console.WriteLine(teens);
            }
            if (num < 10)
            {
                Console.WriteLine(singleDigit);
            }
            if (num > 20 && num % 10 != 0)
            {
                Console.WriteLine("{0} {1}", tensDigit, singleDigit);
            }
            if (num % 10 == 0)
            {
                Console.WriteLine(tensDigit);
            }
            if (num == 100)
            {
                Console.WriteLine("one hundred");
            }

        }
    }
}
