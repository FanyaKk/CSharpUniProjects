using System;
using System.Text.RegularExpressions;

namespace BossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#");

                Match validInput = regex.Match(input);

                if (validInput.Success)
                {
                    Console.WriteLine($"{validInput.Groups["name"]}, The {validInput.Groups["title"]}");
                    Console.WriteLine($">> Strength: {validInput.Groups["name"].Length}");
                    Console.WriteLine($">> Armour: {validInput.Groups["title"].Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
