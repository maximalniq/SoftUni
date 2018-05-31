using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            bool firstArrayIsSmaller = false;

            if (firstArray.Length <= secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] < secondArray[i])
                    {
                        firstArrayIsSmaller = true;
                        break;
                    }
                    else
                    {
                        firstArrayIsSmaller = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (firstArray[i] < secondArray[i])
                    {
                        firstArrayIsSmaller = true;
                        break;
                    }
                    else
                    {
                        firstArrayIsSmaller = false;
                        break;
                    }
                }
            }

            if (firstArrayIsSmaller)
            {
                Console.WriteLine(string.Join("",firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
        }
    }
}
