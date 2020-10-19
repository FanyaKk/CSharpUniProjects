using System;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string currLongestSeq = input[0];
            string longestSequence = "";

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    currLongestSeq += " " + input[i];
                }
                else
                {
                    currLongestSeq = input[i];
                }
                if (currLongestSeq.Length > longestSequence.Length)
                {
                    longestSequence = currLongestSeq;
                }                             
            }
            Console.WriteLine(longestSequence);
        }
    }
}
