using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usersFile;
            bool loggedInUser = false;

            if (File.Exists("users.txt"))
            {
                usersFile = File.ReadAllLines("users.txt");
            }
            else
            {
                File.Create("users.txt");
                usersFile = File.ReadAllLines("users.txt");
            }

            var users = new List<string>(usersFile);

            string input = Console.ReadLine();

            while (input != "exit")
            {
                string[] currentInput = input.Split();

                if (currentInput[0] == "register")
                {
                    string username = currentInput[1];
                    string password = currentInput[2];
                    string confirmPassword = currentInput[3];

                    if (password == confirmPassword)
                    {
                        if (!users.Contains(username))
                        {
                            users.Add(username);
                            users.Add(password);
                            File.AppendAllText("users.txt", username + Environment.NewLine);
                            File.AppendAllText("users.txt", password + Environment.NewLine);
                        }
                        else
                        {
                            Console.WriteLine("The given username already exists.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The two passwords must match.");
                    }

                    
                }

                if (currentInput[0] == "login")
                {

                    if (!loggedInUser)
                    {
                        if (!users.Contains(currentInput[1]))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else
                        {
                            int index = users.IndexOf(currentInput[1]) + 1;

                            if (users[index] == currentInput[2])
                            {
                                loggedInUser = true;
                            }
                            else
                            {
                                Console.WriteLine("The password you entered is incorrect.");
                            }
                        }                       
                    }
                    else
                    {
                        Console.WriteLine("There is already a logged in user.");
                    }
                    
                }

                if (currentInput[0] == "logout")
                {
                    loggedInUser = false;
                }

                input = Console.ReadLine();
            }
        }
    }
}
