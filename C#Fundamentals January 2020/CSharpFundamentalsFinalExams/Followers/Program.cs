using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, List<int>> users = new Dictionary<string, List<int>>();

            while ((input = Console.ReadLine()) != "Log out")
            {
                string[] command = input.Split(": ");
                string username = command[1];

                if (command[0]== "New follower")
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new List<int>() { 0, 0 });
                    }
                }
                else if (command[0] == "Like")
                {
                    int count = int.Parse(command[2]);
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new List<int>() { 0, 0 });
                    }
                    users[username][0] += count;
                }
                else if (command[0] == "Comment")
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new List<int>() { 0, 0 });
                    }
                    users[username][1]++;
                }
                else if (command[0] == "Blocked")
                {
                    if (!users.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        users.Remove(username);
                    }
                }
            }
            Console.WriteLine($"{users.Count} followers");

            users = users
                .OrderByDescending(likes => likes.Value[0])
                .ThenBy(usernames => usernames.Key)
                .ToDictionary(k => k.Key, v => v.Value);
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}: {user.Value[0] + user.Value[1]}");
            }
        }
    }
}
