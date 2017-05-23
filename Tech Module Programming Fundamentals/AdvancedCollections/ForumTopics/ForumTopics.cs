using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var data = new Dictionary<string, HashSet<string>>();

            while (input[0] != "filter")
            {
                if (!data.ContainsKey(input[0]))
                {
                    data[input[0]] = new HashSet<string>();
                    for (int i = 1; i < input.Length; i++)
                    {
                        data[input[0]].Add(input[i]);
                    }
                }
                else
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        data[input[0]].Add(input[i]);
                    }
                }

                input = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            var inputTags = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var nameAndHash in data)
            {
                bool isContainsAllTags = !inputTags.Except(nameAndHash.Value).Any();

                if (isContainsAllTags)
                {
                    Console.Write($"{nameAndHash.Key} | ");
                    foreach (var tags in nameAndHash.Value)
                    {
                        if (tags.Equals(nameAndHash.Value.Last()))
                        {
                            Console.Write($"#{tags}");
                            break;
                        }
                        Console.Write($"#{tags}, ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
