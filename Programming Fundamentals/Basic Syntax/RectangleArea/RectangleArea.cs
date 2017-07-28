using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            var num1 = float.Parse(Console.ReadLine());
            var num2 = float.Parse(Console.ReadLine());

            float area = num1 * num2;
            Console.WriteLine("{0:f2}", area);
        }
    }
}
