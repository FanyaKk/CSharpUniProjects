using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            List<int> asciiNumbers = new List<int>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();

                Regex regex = new Regex(@"!(?<command>[A-Z][a-z]{3,})!:\[(?<message>[A-Za-z]{8,})\]");
                Match validMessage = regex.Match(message);

                if (validMessage.Success)
                {
                    string resultMessage = validMessage.Groups["message"].Value;
                    for (int j = 0; j < resultMessage.Length; j++)
                    {
                        int value = resultMessage[j];
                        asciiNumbers.Add(value);
                    }
                    Console.WriteLine($"{validMessage.Groups["command"]}: {string.Join(" ", asciiNumbers)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
