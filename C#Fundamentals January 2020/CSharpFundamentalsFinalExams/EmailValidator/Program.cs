using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string command = "";

            while((command = Console.ReadLine()) != "Complete")
            {
                string[] currCommand = command.Split();
                if(command == "Make Upper")
                {
                    email = email.ToUpper();
                    Console.WriteLine(email);
                }
                else if (command == "Make Lower")
                {
                    email = email.ToLower();
                    Console.WriteLine(email);
                }
                else if (currCommand[0] == "GetDomain")
                {
                    int count = int.Parse(currCommand[1]);
                    string domain = email.Substring(email.Length - count);
                    Console.WriteLine(domain);
                }
                else if (command == "GetUsername")
                {
                    int index = email.IndexOf("@");
                    if (index < 0)
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        string username = email.Substring(0, index);
                        Console.WriteLine(username);
                    }                 
                }
                else if (currCommand[0] == "Replace")
                {
                    char symbol = char.Parse(currCommand[1]);
                    email = email.Replace(symbol, '-');
                    Console.WriteLine(email);
                }
                else if (command == "Encrypt")
                {
                    List<int> asciiValue = new List<int>();
                    for (int i = 0; i < email.Length; i++)
                    {
                        asciiValue.Add(email[i]);
                    }
                    Console.WriteLine(string.Join(" ", asciiValue));
                }
            }
        }
    }
}
