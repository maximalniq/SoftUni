using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());

            if (age >= 16 && sex == 'm')
            {
                Console.WriteLine("Mr.");
            }
            else if (age < 16 && sex == 'm')
            {
                Console.WriteLine("Master");
            }
            else if (age >= 16 && sex == 'f')
            {
                Console.WriteLine("Ms.");
            }
            else if (age < 16 && sex == 'f')
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
