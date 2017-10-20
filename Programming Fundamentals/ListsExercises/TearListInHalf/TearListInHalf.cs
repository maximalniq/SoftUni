using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            var initialList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var topList = new List<int>();
            var bottomList = new List<int>();

            for (int i = 0; i < initialList.Count(); i++)
            {
                if (i < initialList.Count() / 2)
                {
                    topList.Add(initialList[i]);
                }
                else
                {
                    bottomList.Add(initialList[i]);
                }
            }

            for (int i = 0; i < topList.Count(); i++)
            {

            }

        }
    }
}
