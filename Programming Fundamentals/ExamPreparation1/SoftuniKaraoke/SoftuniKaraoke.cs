using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniKaraoke
{
    class SoftuniKaraoke
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var availableSongs = Console.ReadLine()
                .Split(new[] {", "},StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var input = Console.ReadLine();

            while (input != "dawn")
            {
                string[] inputParams = input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            }
        }
    }
}
