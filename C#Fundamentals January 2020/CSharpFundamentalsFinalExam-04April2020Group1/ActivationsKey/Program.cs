using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string rawKey = Console.ReadLine();
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] splittedInput = input.Split(">>>");
                string command = splittedInput[0];
                if (command == "Contains")
                {
                    string substring = splittedInput[1];
                    if (rawKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string subCommand = splittedInput[1];
                    int startIndex = int.Parse(splittedInput[2]);
                    int endIndex = int.Parse(splittedInput[3]);
                    if (subCommand == "Upper")
                    {
                        int count = endIndex - startIndex;
                        string substring = rawKey.Substring(startIndex, count);
                        string newsubString = rawKey.Substring(startIndex, count).ToUpper();
                        rawKey = rawKey.Replace(substring, newsubString);
                        //rawKey = rawKey.Remove(startIndex, count);
                        //rawKey = rawKey.Insert(startIndex, subString);
                        Console.WriteLine(rawKey);

                    }
                    else if (subCommand == "Lower")
                    {
                        int count = endIndex - startIndex;
                        string substring = rawKey.Substring(startIndex, count);
                        string newsubString = rawKey.Substring(startIndex, count).ToLower();
                        rawKey = rawKey.Replace(substring, newsubString);
                        //rawKey = rawKey.Remove(startIndex, count);
                        //rawKey = rawKey.Insert(startIndex, subString);
                        Console.WriteLine(rawKey);
                    }
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(splittedInput[1]);
                    int endIndex = int.Parse(splittedInput[2]);
                    int lenght = endIndex - startIndex;
                    rawKey = rawKey.Remove(startIndex, lenght);
                    Console.WriteLine(rawKey);

                }
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}

//using System;

//namespace ActivationsKey
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string activationKey = Console.ReadLine();
//            string input = "";

//            while ((input = Console.ReadLine()) != "Generate")
//            {
//                string[] command = input.Split(">>>");

//                if(command[0] == "Contains")
//                {
//                    if (activationKey.Contains(command[1]))
//                    {
//                        Console.WriteLine($"{activationKey} contains {command[1]}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Substring not found!");
//                    }
//                }
//                else if (command[0]== "Flip")
//                {
//                    int startIndex = int.Parse(command[2]);
//                    int length = int.Parse(command[3]) - startIndex;
//                    string substring = activationKey.Substring(startIndex, length);
//                    string newSubstring = "";
//                    if (command[1] == "Upper")
//                    {
//                        newSubstring = substring.ToUpper();
//                        activationKey = activationKey.Replace(substring, newSubstring);
//                    }
//                    else if (command[1] == "Lower")
//                    {
//                        newSubstring = substring.ToLower();
//                        activationKey = activationKey.Replace(substring, newSubstring);
//                    }
//                    Console.WriteLine(activationKey);
//                }
//                else if (command[0] == "Slice")
//                {
//                    int startIndex = int.Parse(command[1]);
//                    int length = int.Parse(command[2]) - startIndex;
//                    activationKey = activationKey.Remove(startIndex, length);
//                    Console.WriteLine(activationKey);
//                }
//            }
//            Console.WriteLine($"Your activation key is: {activationKey}");
//        }
//    }
//}
