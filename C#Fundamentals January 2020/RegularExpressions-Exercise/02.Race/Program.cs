using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ").ToArray();

            Dictionary<string, int> participantsList = new Dictionary<string,int>();

            string command = string.Empty;
            string namePattern = @"(?<name>[A-Za-z])";
            string digitsPattern = @"(?<digits>[\d])";
            
            while ((command = Console.ReadLine()) != "end of race")
            {
                MatchCollection validName = Regex.Matches(command, namePattern);
                MatchCollection validDigits = Regex.Matches(command, digitsPattern);

                int participantKilometers = 0;
                string name = "";
                string digits = "";

                foreach (Match item in validName)
                {
                    name += item.Groups["name"].Value;
                }
                foreach (Match item in validDigits)
                {
                    digits = item.Groups["digits"].Value;
                    participantKilometers += int.Parse(digits);
                }

                if (name != string.Empty)
                {           
                    for (int i = 0; i < participants.Length; i++)
                    {
                        if (name == participants[i])
                        {
                            if (!participantsList.ContainsKey(name))
                            {
                                participantsList.Add(name, new int());
                            }
                            participantsList[name]+=participantKilometers;
                        }   
                    }
                } 
            }
            participantsList = participantsList
                .OrderByDescending(kvp => kvp.Value)
                .Take(3)
                .ToDictionary(a => a.Key, b => b.Value);
            int counter = 1;
            foreach (var racers in participantsList)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {racers.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {racers.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {racers.Key}");
                }
                counter++;
            }
        }
    }
}
