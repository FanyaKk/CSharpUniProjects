﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            WinnigDeck(firstDeck, secondDeck);
        }
        static void WinnigDeck (List<int> firstDeck, List<int> secondDeck)
        {
            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.Add(secondDeck[0]);
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else if (secondDeck[0] > firstDeck[0])
                {
                    secondDeck.Add(secondDeck[0]);
                    secondDeck.Add(firstDeck[0]);
                    secondDeck.RemoveAt(0);
                    firstDeck.RemoveAt(0);
                }
                else if (firstDeck[0] == secondDeck[0])
                {
                    secondDeck.RemoveAt(0);
                    firstDeck.RemoveAt(0);
                }
            }
            if (firstDeck.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
            else if (secondDeck.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
        }
    }
}
