using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Website
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }
    }

    class Websites
    {
        static void Main(string[] args)
        {
            List<Website> websites = new List<Website>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input.Split(new char[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string host = inputParams[0];
                string domain = inputParams[1];
                List<string> queries = inputParams.Skip(2).ToList();

                Website newWebsite = new Website();

                newWebsite.Host = host;
                newWebsite.Domain = domain;
                newWebsite.Queries = queries;

                websites.Add(newWebsite);

                input = Console.ReadLine();
            }

            foreach (var kvp in websites)
            {
                if (kvp.Queries.Count != 0)
                {
                    Console.WriteLine($"https://www.{kvp.Host}.{kvp.Domain}/query?=[{string.Join("]&[", kvp.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{kvp.Host}.{kvp.Domain}");
                }
            }
        }
    }
}
