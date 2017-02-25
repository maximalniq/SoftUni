using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<string>();

            for (int i = 0; ; i++)
            {
                List[i] = Console.ReadLine();
                if (List[i] == "end")
                {
                    break;
                }
            }
        }
    }
}
