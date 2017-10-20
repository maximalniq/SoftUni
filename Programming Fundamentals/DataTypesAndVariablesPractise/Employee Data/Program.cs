using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nereshena
            string firstName = Console.ReadLine();
            string lastname = Console.ReadLine();
            var age = byte.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            var personalI = long.Parse(Console.ReadLine());
            var employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalI);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
