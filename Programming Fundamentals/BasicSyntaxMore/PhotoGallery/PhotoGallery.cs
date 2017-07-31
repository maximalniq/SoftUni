using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            var photoNumbers = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSize = decimal.Parse(Console.ReadLine());
            var photoWidth = int.Parse(Console.ReadLine());
            var photoHeight = int.Parse(Console.ReadLine());


            var date = ($"{day:d2}/{month:d2}/{year:d4} {hours:d2}:{minutes:d2}");
            var resolution = string.Empty;
            var humanReadableSize = string.Empty;

            if (photoWidth < photoHeight)
            {
                resolution = "portrait";
            }
            else if (photoWidth > photoHeight)
            {
                resolution = "landscape";
            }
            else
            {
                resolution = "square";
            }



            if (photoSize < 1000)
            {
                humanReadableSize = "B";
            }
            else if (photoSize < 1000000)
            {
                humanReadableSize = "KB";
                photoSize = Math.Round((photoSize / 1000), 1);
            }
            else
            {
                humanReadableSize = "MB";
                photoSize = Math.Round((photoSize / 1000000), 1);
            }

            Console.WriteLine($"Name: DSC_{photoNumbers:d4}.jpg");
            Console.WriteLine($"Date Taken: {date}");
            Console.WriteLine($"Size: {photoSize}{humanReadableSize}");
            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} ({resolution})");
        }
    }
}
