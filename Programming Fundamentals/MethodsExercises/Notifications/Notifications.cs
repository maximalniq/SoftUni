using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string result = Console.ReadLine();
                if (result == "success")
                {
                    string sOperation = Console.ReadLine();
                    string sMessage = Console.ReadLine();
                    ShowSuccess(sOperation, sMessage);
                }
                else if (result == "error")
                {
                    string eOperation = Console.ReadLine();
                    int eCode = int.Parse(Console.ReadLine());
                    ShowError(eOperation, eCode);
                }

            }
        }
        static void ShowSuccess(string sOperation, string sMessage)
        {
            Console.WriteLine($"Successfully executed {sOperation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {sMessage}.");
        }
        static void ShowError(string eOperation, int eCode)
        {
            string posReason = "Invalid Client Data.";
            string negReason = "Internal System Failure.";
            if (eCode >= 0)
            {
                Console.WriteLine($@"Error: Failed to execute {eOperation}.");
                Console.WriteLine("==============================");
                Console.WriteLine($"Error Code: {eCode}.");
                Console.WriteLine($"Reason: {posReason}");
            }
            else
            {
                Console.WriteLine($@"Error: Failed to execute {eOperation}.");
                Console.WriteLine("==============================");
                Console.WriteLine($"Error Code: {eCode}.");
                Console.WriteLine($"Reason: {negReason}");
            }
        }
    }
}
