using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternText = @"(::|\*\*)(?<name>[A-Z][a-z]{2,})(\1)";
            string patternNumbers = @"\d";
            MatchCollection mathesText = Regex.Matches(input, patternText);
            MatchCollection matchesNumbers = Regex.Matches(input, patternNumbers);
            List<string> emojies = new List<string>();
            int matchCounter = 0;
            long coolSum = 1;
            double asciiSum = 0;
            long theNumber = 0;
            foreach (Match item in matchesNumbers)
            {
                theNumber = long.Parse(item.ToString());
                coolSum *= theNumber;
            }
            foreach (Match item in mathesText)
            {
                matchCounter++;
                string name = item.Groups["name"].Value;
                for (int i = 0; i < name.Length; i++)
                {
                    int number = name[i];
                    asciiSum += number;
                }
                if (asciiSum >= coolSum)
                {
                    emojies.Add(item.ToString());
                    asciiSum = 0;
                }
            }

            Console.WriteLine($"Cool threshold: {coolSum}");
            Console.WriteLine($"{matchCounter} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join(" \n", emojies));
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;
//using System.Linq;

//namespace EmojiDetector
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string text = Console.ReadLine();
//            Regex emojies = new Regex(@"([\*][\*]|[\:][\:])(?<emoji>[A-Z][a-z]{2,})\1");
//            Regex numbers = new Regex(@"\d");
//            List<string> coolThreshold = new List<string>();
//            long numberResult = 1;
//            MatchCollection validEmoji = emojies.Matches(text);
//            MatchCollection validNumbers = numbers.Matches(text);
//            foreach (Match number in validNumbers)
//            {
//                long currNumber = long.Parse(number.ToString());
//                numberResult *= currNumber;
//            }

//            foreach (Match emoji in validEmoji)
//            {
//                string currEmoji = emoji.Groups["emoji"].Value;
//                long emojiResult = 0;
//                for (int i = 0; i < currEmoji.Length; i++)
//                {                    
//                    int asciiValue = currEmoji[i];
//                    emojiResult += asciiValue;   
//                }
//                if (emojiResult >= numberResult)
//                {
//                    coolThreshold.Add(emoji.ToString());
//                }
//            }
//            Console.WriteLine($"Cool threshold: {numberResult}");
//            Console.WriteLine($"{validEmoji.Count} emojis found in the text. The cool ones are:");
//            Console.WriteLine($"{string.Join(" \n", coolThreshold)}");
//        }
//    }
//}
