using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref
{
    class DictRef
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var dictionary = new Dictionary<string, int>();

            while (input[0] != "end")
            {

                var numberOfInput = int.Parse(input[1]);

                if (!dictionary.ContainsKey(input[0]))
                {
                    dictionary.Add(input[0], numberOfInput);
                }
                else
                {
                    dictionary[input[0]] = numberOfInput;
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
        }
    }
}
