using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequencesLength = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int[] bestDNA = new int[sequencesLength];

            int bestDNASum = 0;
            int DNACount = -1;
            int smallerStartIndex = -1;
            int DNASample = 0;
            int sample = 0;


            while (command != "Clone them!")
            {  
                sample++;
                int[] currentDNA = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                bool betterDNA = false;
                int bestCount = 0;
                int currentCount = 0;
                int currentEndIndex = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 0)
                    {
                        currentCount = 0;
                        continue;
                    }
                    currentCount++;

                    if (bestCount < currentCount)
                    {
                        bestCount = currentCount;
                        currentEndIndex = i;
                    }
                }
                int currentSum = currentDNA.Sum();
                int currentStartIndex = currentEndIndex - bestCount + 1;

                if (bestCount > DNACount)
                {
                    betterDNA = true;
                }
                else if (bestCount == DNACount)
                {
                    if (currentStartIndex < smallerStartIndex)
                    {
                        betterDNA = true;
                    }
                    else if (currentStartIndex == currentEndIndex)
                    {
                        if (currentSum > bestDNASum)
                        {
                            betterDNA = true;
                        }
                    }
                }
                
                if (betterDNA == true)
                {
                    bestDNA = currentDNA;
                    DNACount = bestCount;
                    smallerStartIndex = currentStartIndex;
                    bestDNASum = currentSum;
                    DNASample = sample;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {DNASample} with sum: {bestDNASum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
