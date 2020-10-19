using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, List<int>> records = new Dictionary<string, List<int>>();

            while ((input = Console.ReadLine()) != "Results")
            {
                string[] command = input.Split(":");

                if (command[0] == "Add")
                {
                    string personName = command[1];
                    int health = int.Parse(command[2]);
                    int energy = int.Parse(command[3]);
                    if (!records.ContainsKey(personName))
                    {
                        records.Add(personName, new List<int>() { health, energy });
                    }
                    else
                    {
                        records[personName][0] += health;
                    }                    
                }
                else if (command[0] == "Attack")
                {
                    string attackerName = command[1];
                    string defenderName = command[2];
                    int damage = int.Parse(command[3]);
                    if (records.ContainsKey(attackerName) && records.ContainsKey(defenderName))
                    {
                        records[defenderName][0] -= damage;
                        records[attackerName][1]--;
                        if (records[defenderName][0] <= 0)
                        {
                            records.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }
                        if(records[attackerName][1] == 0)
                        {
                            records.Remove(attackerName);
                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }

                }
                else if (command[0] == "Delete")
                {
                    string username = command[1];
                    if(username == "All")
                    {
                        records.Clear();
                    }
                    else if (records.ContainsKey(username))
                    {
                        records.Remove(username);
                    }
                }               
            }
            records = records
                    .OrderByDescending(health => health.Value[0])
                    .ThenBy(name => name.Key)
                    .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"People count: {records.Count}");
            foreach (var record in records)
            {
                Console.WriteLine($"{record.Key} - {record.Value[0]} - {record.Value[1]}");
            }
        }
    }
}
