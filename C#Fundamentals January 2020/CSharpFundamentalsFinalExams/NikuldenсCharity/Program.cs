using System;

namespace NikuldenсCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = "";
            int asciiSum = 0;

            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] command = input.Split();

                if (command[0] == "Replace")
                {
                    char currChar = char.Parse(command[1]);
                    char newChar = char.Parse(command[2]);
                    text = text.Replace(currChar, newChar);
                    Console.WriteLine(text);
                }
                else if (command[0] == "Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (startIndex < 0 || startIndex >= text.Length || endIndex < 0 || endIndex >= text.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        int length = endIndex - startIndex + 1;
                        text = text.Remove(startIndex, length);
                        Console.WriteLine(text);
                    }
                }
                else if (command[0] == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        text = text.ToUpper();
                    }
                    else
                    {
                        text = text.ToLower();
                    }
                    Console.WriteLine(text);
                }
                else if (command[0] == "Check")
                {
                    if (text.Contains(command[1]))
                    {
                        Console.WriteLine($"Message contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {command[1]}");
                    }
                }
                else if (command[0] == "Sum")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int length = endIndex - startIndex + 1;
                    
                    if (startIndex < 0 || startIndex >= text.Length || endIndex < 0 || endIndex >= text.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        string textSubstring = text.Substring(startIndex, length);

                        for (int i = 0; i < textSubstring.Length; i++)
                        {
                            int value = textSubstring[i];
                            asciiSum += value;
                        }
                        Console.WriteLine(asciiSum);
                    }   
                }
            }
        }
    }
}
