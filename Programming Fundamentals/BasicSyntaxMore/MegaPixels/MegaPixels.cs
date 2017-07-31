using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPixels
{
    class MegaPixels
    {
        static void Main(string[] args)
        {
            var width = float.Parse(Console.ReadLine());
            var height = float.Parse(Console.ReadLine());

            float megapixels = (width * height) / 1000000;

            Console.WriteLine($"{width}x{height} > {Math.Round(megapixels, 1)}MP");
        }
    }
}
