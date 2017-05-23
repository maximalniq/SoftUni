using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                 .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            var userData = new Dictionary<string, string>();
            int failedLoginsCounter = 0;

            while (input[0] != "login")
            {
                if (!userData.ContainsKey(input[0]))
                {
                    userData.Add(input[0], input[1]);
                }
                else
                {
                    userData[input[0]] = input[1];
                }

                input = Console.ReadLine()
                 .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            }

            input = Console.ReadLine()
                 .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            while (input[0] != "end")
            {
                if (userData.ContainsKey(input[0]) && userData.ContainsValue(input[1]))
                {
                    Console.WriteLine($"{input[0]}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{input[0]}: login failed");
                    failedLoginsCounter++;
                }

                input = Console.ReadLine()
                 .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            }

            Console.WriteLine($"unsuccessful login attempts: {failedLoginsCounter}");
        }
    }
}
