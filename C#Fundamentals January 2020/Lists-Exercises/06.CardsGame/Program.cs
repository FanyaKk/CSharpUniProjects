using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {
            List<int> firstDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                int firstPlayerCard = firstDeck[0];
                int secondPlayerCard = secondDeck[0];
                if (firstPlayerCard > secondPlayerCard)
                {
                    firstDeck.Add(firstPlayerCard);
                    firstDeck.Add(secondPlayerCard);
                    firstDeck.Remove(firstPlayerCard);
                    secondDeck.Remove(secondPlayerCard);
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondDeck.Add(secondPlayerCard);
                    secondDeck.Add(firstPlayerCard);
                    secondDeck.Remove(secondPlayerCard);
                    firstDeck.Remove(firstPlayerCard);   
                }
                else if (firstPlayerCard == secondPlayerCard)
                {
                    firstDeck.Remove(firstPlayerCard);
                    secondDeck.Remove(secondPlayerCard);
                }

            }
            if (firstDeck.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else if (secondDeck.Count < 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
        }
        //static void Main(string[] args)               //version 1.0
        //{
        //    List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    WinnigDeck(firstDeck, secondDeck);
        //}
        //static void WinnigDeck (List<int> firstDeck, List<int> secondDeck)
        //{
        //    while (firstDeck.Count > 0 && secondDeck.Count > 0)
        //    {
        //        if (firstDeck[0] > secondDeck[0])
        //        {
        //            firstDeck.Add(firstDeck[0]);
        //            firstDeck.Add(secondDeck[0]);
        //            firstDeck.RemoveAt(0);
        //            secondDeck.RemoveAt(0);
        //        }
        //        else if (secondDeck[0] > firstDeck[0])
        //        {
        //            secondDeck.Add(secondDeck[0]);
        //            secondDeck.Add(firstDeck[0]);
        //            secondDeck.RemoveAt(0);
        //            firstDeck.RemoveAt(0);
        //        }
        //        else if (firstDeck[0] == secondDeck[0])
        //        {
        //            secondDeck.RemoveAt(0);
        //            firstDeck.RemoveAt(0);
        //        }
        //    }
        //    if (firstDeck.Count == 0)
        //    {
        //        Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
        //    }
        //    else if (secondDeck.Count == 0)
        //    {
        //        Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
        //    }
        //}
    }
}
//Exercise 6. Cards Game

//You will be given two hands of cards, which will be integer numbers.Assume that you have two players.You have to
//find out the winning deck and respectively the winner.

//You start from the beginning of both hands. Compare the cards from the first deck to the cards from the second
//deck. The player, who has the bigger card, takes both cards and puts them at the back of his hand - the second
//player’s card is last, and the first person’s card (the winning one) is before it(second to last) and the player with
//the smaller card must remove the card from his deck.If both players’ cards have the same values - no one wins, and
//the two cards must be removed from the decks. The game is over, when one of the decks is left without any cards.
//You have to print the winner on the console and the sum of the left cards: "{First/Second} player wins! Sum: {sum}".

//Examples:

//Input            |     Output
//--------------------------------------------------------
//20 30 40 50      |     First player wins! Sum: 240
//10 20 30 40      |
//--------------------------------------------------------
//10 20 30 40 50   |     Second player wins! Sum: 50
//50 40 30 30 10   |