using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string firstStr = words[0];
            string secondStr = words[1];

            string longerWord = "";
            string shorterWord = "";

            if (firstStr.Length > secondStr.Length)
            {
                longerWord = firstStr;
                shorterWord = secondStr;
            }
            else
            {
                longerWord = secondStr;
                shorterWord = firstStr;
            }
            double sum = 0;

            for (int i = 0; i < longerWord.Length; i++)
            {
                int firstValue = longerWord[i];
                int secondValue = 1;
                if (shorterWord.Length > i)
                {
                    secondValue = shorterWord[i];
                }
                
                sum += firstValue * secondValue;
            }
            Console.WriteLine(sum);
        }
    }
}
