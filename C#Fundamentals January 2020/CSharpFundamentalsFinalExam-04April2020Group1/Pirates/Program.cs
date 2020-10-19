using System;
using System.Linq;
using System.Collections.Generic;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, List<int>> citiesList = new Dictionary<string, List<int>>(); 

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] cities = input.Split("||").ToArray();

                string town = cities[0];
                town.IndexOf('a');
                int people = int.Parse(cities[1]);
                int gold = int.Parse(cities[2]);

                if (!citiesList.ContainsKey(town))
                {
                    citiesList.Add(town, new List<int> { 0, 0 });
                }
                citiesList[town][0] += people;
                citiesList[town][1] += gold;
            }
            while((input = Console.ReadLine()) != "End")
            {
                string[] events = input.Split("=>").ToArray();

                if (events[0]== "Plunder")
                {
                    string town = events[1];
                    int people = int.Parse(events[2]);
                    int gold = int.Parse(events[3]);
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    citiesList[town][0] -= people;
                    citiesList[town][1] -= gold;
                    if (citiesList[town][0] == 0 || citiesList[town][1] == 0)
                    {
                        citiesList.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (events[0] == "Prosper")
                {
                    string town = events[1];
                    int gold = int.Parse(events[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        citiesList[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {citiesList[town][1]} gold.");
                    }
                }
            }
            if (input == "End")
            {
                if (citiesList.Count > 0)
                {
                    citiesList = citiesList
                        .OrderByDescending(gold => gold.Value[1])
                        .ThenBy(town => town.Key)
                        .ToDictionary(k => k.Key, v => v.Value);
                    Console.WriteLine($"Ahoy, Captain! There are {citiesList.Count} wealthy settlements to go to:");
                    foreach (var city in citiesList)
                    {
                        Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                    }
                }
                else
                {
                    Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
                }
            }
        }
    }
}
