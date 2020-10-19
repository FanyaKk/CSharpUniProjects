using System;
using System.Collections.Generic;
using System.Linq;

namespace InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            string input = "";

            while((input = Console.ReadLine()) != "Statistics")
            {
                string[] command = input.Split("->");
                string username = command[1];
                if (command[0] == "Add")
                {
                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        users.Add(username, new List<string>());
                    }
                }
                else if (command[0] == "Send")
                {
                    string email = command[2];
                    users[username].Add(email);
                }
                else if (command[0] == "Delete")
                {
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
            }
            Console.WriteLine($"Users count: {users.Count}");

            users = users
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var user in users)
            {
                Console.WriteLine(user.Key);
                //Console.WriteLine($"- {string.Join("\n- ", user.Value)}");
                foreach (var email in user.Value)
                {
                    Console.WriteLine($"- {email}");
                }
            }
        }
    }
}
