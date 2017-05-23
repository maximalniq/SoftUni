using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HTMLContents
{
    class HTMLContents
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> body = new List<string>();
            string title = string.Empty;

            while (input != "exit")
            {
                string[] inputParams = input.Split();
                string currentLine = string.Empty;
                if (inputParams[0] != "title")
                {
                    currentLine = $"<{inputParams[0]}>{inputParams[1]}</{inputParams[0]}>";
                    body.Add(currentLine);
                }
                else
                {
                    title = $"	<{inputParams[0]}>{inputParams[1]}</{inputParams[0]}>";
                }

                input = Console.ReadLine();
            }

            //File.Create("index.html");
            File.AppendAllText("index.html", "<!DOCTYPE html>");
            File.AppendAllText("index.html", "<html>");
            File.AppendAllText("index.html", "<head>");
            File.AppendAllText("index.html", title);
            File.AppendAllText("index.html", "</head>");
            File.AppendAllText("index.html", "<body>");
            File.AppendAllLines("index.html", body);
            File.AppendAllText("index.html", "</body>");
            File.AppendAllText("index.html", "</html>");



            //GenerateHTMLFile();
        }

    }
}
