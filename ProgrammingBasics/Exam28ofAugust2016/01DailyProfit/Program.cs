using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDaysInMonth = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var USDtoBGN = double.Parse(Console.ReadLine());
            double salaryPerMonth;
            double salaryPerYear;
            double tax;
            double profit;
            double convertToBGN;
            double result;
            //Calculations
            salaryPerMonth = workDaysInMonth * moneyPerDay;
            salaryPerYear = salaryPerMonth * 12 + salaryPerMonth * 2.5;
            tax = 25.0 / 100 * salaryPerYear;
            profit = salaryPerYear - tax;
            convertToBGN = profit * USDtoBGN;
            result = convertToBGN / 365;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
