using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Re_Directory
{
    class ReDirectory
    {
        static void Main(string[] args)
        {
            var filesInFolder = Directory.GetFiles("input");

            var extension = Console.ReadLine();
            string trimmedExtension = string.Join("", extension.Split('.'));
            Directory.CreateDirectory($"{trimmedExtension}s");

            foreach (var file in filesInFolder)
            {
                if (extension == Path.GetExtension(file))
                {
                    Directory.Move($"input/{file}", $"{trimmedExtension}s/{file}.{trimmedExtension}");
                }
            }

            Directory.Move($"{trimmedExtension}", "outuput");
        }
    }
}
