using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            var BPM = int.Parse(Console.ReadLine());
            var numberOfBeats = int.Parse(Console.ReadLine());
            double bars = (double)numberOfBeats / 4;
            var seconds = ((numberOfBeats * 60) / BPM);

            var time = TimeSpan.FromSeconds(seconds);
            Console.WriteLine($"{Math.Round(bars, 1)} bars - {time.Minutes}m {time.Seconds}s");

        }
    }
}
