using System;

namespace StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = "";

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] command = input.Split();

                if (command[0] == "Change")
                {
                    text = text.Replace(command[1], command[2]);
                    Console.WriteLine(text);
                }
                else if (command[0] == "Includes")
                {
                    bool isContain = text.Contains(command[1]);
                    Console.WriteLine(isContain);
                }
                else if (command[0] == "End")
                {
                    bool isEnd = text.EndsWith(command[1]);
                    Console.WriteLine(isEnd);
                }
                else if (command[0] == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command[0] == "FindIndex")
                {
                    int index = text.IndexOf(command[1]);
                    Console.WriteLine(index);
                }
                else if (command[0] == "Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    string subString = text.Substring(startIndex, length);
                    Console.WriteLine(subString);
                }
            }
        }
    }
}
