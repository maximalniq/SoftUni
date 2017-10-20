using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var employeePosition = new Dictionary<string, string>();
            var employeeSalary = new Dictionary<string, double>();
            var employeeAge = new Dictionary<string, int>();

            while (input[0] != "filter" && input[1] != "base")
            {
                int age;
                double salary;

                if (int.TryParse(input[1], out age))
                {
                    employeeAge.Add(input[0], age);
                }
                else if (double.TryParse(input[1], out salary))
                {
                    employeeSalary.Add(input[0], salary);
                }
                else
                {
                    employeePosition.Add(input[0], input[1]);
                }

                input = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            var printOutput = Console.ReadLine();

            if (printOutput == "Age")
            {
                foreach (var kvp in employeeAge)
                {
                    Console.WriteLine("Name: " + kvp.Key);
                    Console.WriteLine("Position: " + kvp.Value);
                    Console.WriteLine("====================");
                }
            }

            if (printOutput == "Salary")
            {
                foreach (var kvp in employeeSalary)
                {
                    Console.WriteLine("Name: " + kvp.Key);
                    Console.WriteLine("Position: " + kvp.Value);
                    Console.WriteLine("====================");
                }
            }

            if (printOutput == "Position")
            {
                foreach (var kvp in employeePosition)
                {
                    Console.WriteLine("Name: " + kvp.Key);
                    Console.WriteLine("Position: " + kvp.Value);
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
