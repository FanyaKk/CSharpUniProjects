using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] key = Console.ReadLine().Split();           
            Regex regex = new Regex(@"[\w]+&(?<name>[A-Za-z]+)&[\w]+<(?<coordinates>[\w\d]+)>");

            string input = "";

            while ((input = Console.ReadLine()) != "find")
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < input.Length; i += key.Length)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (i + j < input.Length)
                        {
                            int value = input[i + j] - int.Parse(key[j]);
                            char charachter = (char)value;
                            result.Append(charachter);
                        }
                    }
                }
                Match validResult = regex.Match(result.ToString());
                if (validResult.Success)
                {
                    Console.WriteLine($"Found {validResult.Groups["name"]} at {validResult.Groups["coordinates"]}");
                }                
            }            
        }
    }
}
