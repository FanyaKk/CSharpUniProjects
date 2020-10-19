using System;
using System.Text;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string inputCommand = "";

            while ((inputCommand = Console.ReadLine()) != "Sign up")
            {
                string[] command = inputCommand.Split();

                if (command[0] == "Case")
                {
                    if(command[1] == "lower")
                    {
                        username = username.ToLower();
                    }
                    else
                    {
                        username = username.ToUpper();
                    }
                    Console.WriteLine(username);
                }
                else if (command[0] == "Reverse")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int length = endIndex - startIndex + 1;
                    if (startIndex >= 0 && endIndex < username.Length)   //NOTE: Check if startIndex>username.Length or endIndex<0;
                    {
                        string substring = username.Substring(startIndex, length);
                        char[] substringArray = substring.ToCharArray();
                        Array.Reverse(substringArray);
                        string reverseSubstring = new string(substringArray);
                        Console.WriteLine(reverseSubstring);
                    }    
                }
                else if (command[0] == "Cut")
                {
                    string substring = command[1];
                    int startIndex = username.IndexOf(substring);
                    if (username.Contains(substring.ToString()))
                    {
                        username = username.Remove(startIndex, substring.Length);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {substring}.");
                    }
                }
                else if (command[0] == "Replace")
                {
                    char charForReplace = char.Parse(command[1]);
                    username = username.Replace(charForReplace, '*');
                    Console.WriteLine(username);
                }
                else if (command[0] == "Check")
                {
                    if (username.Contains(command[1]))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {command[1]}.");
                    }
                }
            }

        }
    }
}
