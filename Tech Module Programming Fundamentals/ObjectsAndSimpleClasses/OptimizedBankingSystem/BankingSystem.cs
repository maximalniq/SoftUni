using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedBankingSystem
{
    class BankAccount {

        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }

    }

    class BankingSystem
    {
        static void Main(string[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                string bank = inputParams[0];
                string name = inputParams[1];
                decimal balance = decimal.Parse(inputParams[2]);

                BankAccount newBankAccount = new BankAccount();

                newBankAccount.Name = name;
                newBankAccount.Bank = bank;
                newBankAccount.Balance = balance;

                bankAccounts.Add(newBankAccount);

                input = Console.ReadLine();
            }
            List<BankAccount> SortedBankAccount = bankAccounts.OrderByDescending(o => o.Balance).ToList();

            foreach (var kvp in SortedBankAccount)
            {
                Console.WriteLine($"{kvp.Name} -> {kvp.Balance} ({kvp.Bank})");
            }
        }
    }
}
