using System;
using System.Collections.Generic;
using System.Linq;

namespace Nikuldensmeals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int unlikeMealsCount = 0;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input.Split("-");
                string guest = command[1];
                string meal = command[2];

                if (command[0] == "Like")
                {
                    if (!guests.ContainsKey(guest))
                    {
                        guests.Add(guest, new List<string>());
                    }
                    if (!guests[guest].Contains(meal))
                    {
                        guests[guest].Add(meal);
                    }                   
                }
                else if (command[0] == "Unlike")
                {
                    if (!guests.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else
                    {
                        if (!guests[guest].Contains(meal))
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                        else
                        {
                            guests[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            unlikeMealsCount++;
                        }
                    }
                }
            }
            guests = guests
                .OrderByDescending(meals => meals.Value.Count)
                .ThenBy(guest => guest.Key)
                .ToDictionary(k => k.Key, v => v.Value);
            foreach (var guest in guests)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikeMealsCount}");
        }
    }
}
