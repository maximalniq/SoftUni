using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blackListedWords = Console.ReadLine()
                .Split(' ');
            var resultList = new List<string>();
            string filename = Console.ReadLine();
            

            while (filename != "end")
            {
                bool isThere = false;
               // filename = Console.ReadLine();
                for (int i = 0; i < blackListedWords.Count(); i++)
                {
                    if (filename.Contains(blackListedWords[i]))
                    {
                        isThere = true;
                    }
                }

                if (!isThere)
                {
                    resultList.Add(filename);
                }
                filename = Console.ReadLine();
            }

            foreach (var song in resultList.OrderBy(x => x))
            {
                Console.WriteLine(song);
            }
        }
    }
}
