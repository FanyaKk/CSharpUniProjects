using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();

            string command = "";
            int maxPoints = 0;

            while ((command = Console.ReadLine()) != "exam finished")
            {
                string[] input = command.Split("-").ToArray();
                string username = input[0];
                if (input.Length > 2)
                {
                    string language = input[1];
                    int points = int.Parse(input[2]);
                    if (!participants.ContainsKey(username))
                    {
                        participants.Add(username, points);
                    }
                    if (participants[username] < points)
                    {
                        participants[username] = points;
                    }
                    
                    if (!languages.ContainsKey(language))
                    {
                        languages.Add(language, 0);
                    }
                    languages[language]++;
                }
                else
                {
                    foreach (var item in participants)
                    {
                        if (item.Key == username)
                        {
                            participants.Remove(username);
                        }
                    }
                }
            }
            participants = participants
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);
            languages = languages
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine("Results:");
            foreach (var participant in participants)
            {
                Console.WriteLine($"{participant.Key} | {participant.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var lang in languages)
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}
