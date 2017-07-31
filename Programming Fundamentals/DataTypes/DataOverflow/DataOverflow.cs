using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOverflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            ulong numA = ulong.Parse(Console.ReadLine());
            ulong numB = ulong.Parse(Console.ReadLine());
            ulong biggerNum = 0;
            ulong smallerNum = 0;

            if (numA > numB)
            {
                biggerNum = numA;
                smallerNum = numB;
            }
            else
            {
                biggerNum = numB;
                smallerNum = numA;
            }
            string bigType = "";
            string smallType = "";
            ulong smallTypeMax = 0;

            if (biggerNum >= smallerNum)
            {
                if (biggerNum > byte.MinValue && biggerNum <= byte.MaxValue)
                {
                    bigType = "byte";
                }
                else if (biggerNum > ushort.MinValue && biggerNum <= ushort.MaxValue)
                {
                    bigType = "ushort";
                }
                else if (biggerNum > uint.MinValue && biggerNum <= uint.MaxValue)
                {
                    bigType = "uint";
                }
                else if (biggerNum > ulong.MinValue && biggerNum <= ulong.MaxValue)
                {
                    bigType = "ulong";
                }

                if (smallerNum > byte.MinValue && smallerNum <= byte.MaxValue)
                {
                    smallType = "byte";
                    smallTypeMax = byte.MaxValue;
                }
                else if (smallerNum > ushort.MinValue && smallerNum <= ushort.MaxValue)
                {
                    smallType = "ushort";
                    smallTypeMax = ushort.MaxValue;
                }
                else if (smallerNum > uint.MinValue && smallerNum <= uint.MaxValue)
                {
                    smallType = "uint";
                    smallTypeMax = uint.MaxValue;
                }
                else if (smallerNum > ulong.MinValue && smallerNum <= ulong.MaxValue)
                {
                    smallType = "ulong";
                    smallTypeMax = ulong.MaxValue;
                }
                Console.WriteLine($"bigger type: {bigType}");
                Console.WriteLine($"smaller type: {smallType}");
                Console.WriteLine($"{biggerNum} can overflow {smallType} {Math.Round((double)biggerNum / smallTypeMax)} times");
            }
        }
    }
}
