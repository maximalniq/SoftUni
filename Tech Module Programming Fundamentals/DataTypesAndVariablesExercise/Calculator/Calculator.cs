using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            char op = input[0];
            var num2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine($"{num1} + {num2} = {num1 + num2}"); break;
                case '-': Console.WriteLine($"{num1} - {num2} = {num1 - num2}"); break;
                case '/': Console.WriteLine($"{num1} / {num2} = {num1 / num2}"); break;
                case '*': Console.WriteLine($"{num1} * {num2} = {num1 * num2}"); break;
                default:
                    break;
            }
        }
    }
}
