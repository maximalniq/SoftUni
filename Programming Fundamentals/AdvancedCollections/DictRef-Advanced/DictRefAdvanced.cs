using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRef_Advanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>', ',' },StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var data = new Dictionary<string, List<int>>();
            int number;

            while (input[0] != "end")
            {
                bool isNumber = false;
                if (int.TryParse(input[1], out number))
                {
                    isNumber = true;
                }
                if (isNumber)
                {


                    if (!data.ContainsKey(input[0]))
                    {
                        data[input[0]] = new List<int>();

                        for (int i = 1; i < input.Length; i++)
                        {
                            data[input[0]].Add(int.Parse(input[i]));
                        }
                    }
                    else
                    {
                        for (int i = 1; i < input.Length; i++)
                        {
                            data[input[0]].Add(int.Parse(input[i]));
                        }
                    }
                }
                else
                {
                    if (data.ContainsKey(input[1]) && !isNumber)
                    {
                        data[input[0]] = new List<int>();
                        foreach (var element in data[input[1]])
                        {
                            data[input[0]].Add(element);
                        }
                    }
                    else
                    {

                    }
                }

                input = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var kvp in data)
            {
                Console.WriteLine($"{kvp.Key} === {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
