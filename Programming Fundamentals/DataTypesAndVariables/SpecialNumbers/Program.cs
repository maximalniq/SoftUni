using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nereshena
            int kolkko = int.Parse(Console.ReadLine());
            int obshto = 0;
            for (int ch = 1; ch <= kolkko; ch++)
            {
                int takova = ch;
                while (ch > 0)
                {
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                bool toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine($"{takova} -> {toe}");
                obshto = 0;
                ch = takova;

            }
        }
    }
}
