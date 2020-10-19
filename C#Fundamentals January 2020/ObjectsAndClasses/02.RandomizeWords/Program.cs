﻿using System;
using System.Linq;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfWords = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                int randomPosition = rnd.Next(arrayOfWords.Length);
                string tempWord = arrayOfWords[i];
                arrayOfWords[i] = arrayOfWords[randomPosition];
                arrayOfWords[randomPosition] = tempWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, arrayOfWords)); // Environment.NewLine = "\n"
        }
    }
}
