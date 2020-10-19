using System;
using System.Text.RegularExpressions;

namespace MessageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string message = Console.ReadLine();

                Regex regex = new Regex(@"([\*|@])(?<tag>[A-Z][a-z]{2,})\1: \[([A-Za-z])\]\|\[([A-Za-z])\]\|\[([A-Za-z])\]\|$");
                Match validMessage = regex.Match(message);

                if (validMessage.Success)
                {
                    int firstAscii = char.Parse(validMessage.Groups[2].Value);
                    int secondAscii = char.Parse(validMessage.Groups[3].Value);
                    int thirdAscii = char.Parse(validMessage.Groups[4].Value);

                    Console.WriteLine($"{validMessage.Groups["tag"]}: {firstAscii} {secondAscii} {thirdAscii}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
