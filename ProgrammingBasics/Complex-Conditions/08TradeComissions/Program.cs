using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            double comission = -1;

            if (sales >= 0 && sales <= 500)
            {
                if (town == "sofia")
                {
                    comission = 5;
                }
                else if (town == "varna")
                {
                    comission = 4.5;
                }
                else if (town == "plovdiv")
                {
                    comission = 5.5;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                if (town == "sofia")
                {
                    comission = 7;
                }
                else if (town == "varna")
                {
                    comission = 7.5;
                }
                else if (town == "plovdiv")
                {
                    comission = 8;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                if (town == "sofia")
                {
                    comission = 8;
                }
                else if (town == "varna")
                {
                    comission = 10;
                }
                else if (town == "plovdiv")
                {
                    comission = 12;
                }
            }
            else if (sales > 10000)
            {
                if (town == "sofia")
                {
                    comission = 12;
                }
                else if (town == "varna")
                {
                    comission = 13;
                }
                else if (town == "plovdiv")
                {
                    comission = 14.5;
                }
            }
            if (comission == -1)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}", (comission * sales / 100));
            }
        }
    }
}
