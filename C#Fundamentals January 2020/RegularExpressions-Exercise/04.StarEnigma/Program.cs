using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string pattern = @"s|t|a|r|S|T|A|R";
            
            int attackCount = 0;
            int destroyedCount = 0;

            Dictionary<string, List<string>> planets = new Dictionary<string, List<string>>();
            planets.Add("Attacked planets", new List<string>());
            planets.Add("Destroyed planets", new List<string>());

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                StringBuilder dencryptMessage = new StringBuilder();

                DecryptedMessage(pattern, input, dencryptMessage);

                string secondPattern = @"[@](?<planetName>[A-Z][a-z]+)([^@\-!:>]*):(?<population>[\d]+)([^@\-!:>]*)!(?<attackType>A|D)!([^@\-!:>]*)->(?<soldierCount>[\d]+)";
                Match validMessage = Regex.Match(dencryptMessage.ToString(), secondPattern);

                if (validMessage.Success)
                {
                    SuccessValidation(ref attackCount, ref destroyedCount, planets, validMessage);
                }
            }
            planets = planets
                .OrderBy(k => k.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var category in planets)
            {
                List<string> list = category.Value;
                list.Sort();
                //category.Value.Sort();
                Console.WriteLine($"{category.Key}: {category.Value.Count()}");
                
                foreach (var planet in category.Value)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }

        private static void SuccessValidation(ref int attackCount, ref int destroyedCount, Dictionary<string, List<string>> planets, Match validMessage)
        {
            string planetName = validMessage.Groups["planetName"].Value;
            string attackType = validMessage.Groups["attackType"].Value;

            if (attackType == "A")
            {
                attackType = "Attacked planets";
                planets[attackType].Add(planetName);
                attackCount++;
            }
            else if (attackType == "D")
            {
                attackType = "Destroyed planets";
                planets[attackType].Add(planetName);
                destroyedCount++;
            }
        }

        private static void DecryptedMessage(string pattern, string input, StringBuilder dencryptMessage)
        {
            MatchCollection validInput = Regex.Matches(input, pattern);
            int count = validInput.Count;

            for (int j = 0; j < input.Length; j++)
            {
                int value = input[j];
                int newValue = value - count;
                dencryptMessage.Append((char)newValue);
            }
        }
    }
}
