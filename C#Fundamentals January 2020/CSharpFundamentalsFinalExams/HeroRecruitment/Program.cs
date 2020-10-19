using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                string heroName = command[1];
                

                if (command[0] == "Enroll")
                {
                    if (!heroes.ContainsKey(heroName))
                    {
                        heroes[heroName] = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                else if (command[0] == "Learn")
                {
                    string spellName = command[2];
                    if (heroes.ContainsKey(heroName))
                    {
                        if (heroes[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                        else
                        {
                            heroes[heroName].Add(spellName);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
                else if (command[0] == "Unlearn")
                {
                    string spellName = command[2];
                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else
                    {
                        if (heroes[heroName].Contains(spellName))
                        {
                            heroes[heroName].Remove(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }      
                    }                    
                }
            }
            heroes = heroes
                    .OrderByDescending(kvp => kvp.Value.Count)
                    .ThenBy(kvp => kvp.Key)
                    .ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
