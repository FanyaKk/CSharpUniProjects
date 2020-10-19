using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> profiles = new Dictionary<string, List<string>>();

            string command = "";

            string forceUser = "";
            string forceSide = "";

            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                //List<string> input = command.Split().ToList();
                string[] input = command.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command.Contains("|"))
                {
                    //input = command.Split(" | ").ToList();
                    forceUser = input[1];
                    forceSide = input[0];

                    if (!profiles.ContainsKey(forceSide))
                    {
                        profiles.Add(forceSide, new List<string>());
                    }
                    if(!profiles.Values.Any(x => x.Contains(forceUser)))
                    {
                        profiles[forceSide].Add(forceUser);
                    }   
                }
                else if (command.Contains("->"))
                {
                    //input = command.Split(" -> ").ToList();
                    forceUser = input[0];
                    forceSide = input[1];

                    foreach (var item in profiles)
                    {
                        if (item.Value.Contains(forceUser))
                        {
                            item.Value.Remove(forceUser);
                        }
                    }
                    if (!profiles.ContainsKey(forceSide))
                    {
                        profiles.Add(forceSide, new List<string>());   
                    }
                    profiles[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!"); 
                }
            }
            profiles = profiles
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);
            foreach (var profile in profiles)
            {
                List<string> sort = profile.Value
                    .OrderBy(v => v)
                    .ToList();

                if (profile.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {profile.Key}, Members: {sort.Count}");
                    Console.WriteLine($"! {string.Join("\n! ", sort)}");
                }
            }
        }
    }
}
