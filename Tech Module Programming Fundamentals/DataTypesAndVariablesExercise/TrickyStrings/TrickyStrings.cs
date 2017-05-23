using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStrings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            string text = string.Empty;
            string lastPart = string.Empty;
            for (int i = 0; i < N; i++)
            {
                string someText = Console.ReadLine();
                if (i < N - 1)
                {
                    text += someText;
                    text += delimiter;
                }
                else if (i == N - 1)
                {
                    lastPart += someText;
                }


            }
            Console.Write(text);
            Console.WriteLine(lastPart);
        }
    }
}
