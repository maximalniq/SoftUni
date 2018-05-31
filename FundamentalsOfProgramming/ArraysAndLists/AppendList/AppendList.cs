using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class AppendList
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var result = new List<string>();
            Array.Reverse(input);
            foreach (var token in input)
            {
                string[] numbers = token.Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in numbers)
                {
                    if (item != " ")
                    {
                        result.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
