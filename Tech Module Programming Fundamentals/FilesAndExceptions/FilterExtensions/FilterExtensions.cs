using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilterExtensions
{
    class FilterExtensions
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] fileNames = Directory.GetFiles("input");

            foreach (var file in fileNames)
            {
                string extention = Path.GetExtension(file);
                if (input == extention)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}
