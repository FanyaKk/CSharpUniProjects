using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> regUsers = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                string username = command[1];
                
                if (command[0] == "register")
                {
                    string license = command[2];
                    if (!regUsers.ContainsKey(username))
                    {
                        regUsers[username] = license;
                        Console.WriteLine($"{username} registered {license} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (regUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        regUsers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            foreach (var user in regUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
