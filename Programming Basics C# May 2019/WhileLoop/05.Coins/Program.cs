﻿using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal coins = decimal.Parse(Console.ReadLine());
            coins *= 100;
            int coinsCount = 0;

            while(coins > 0)
            {
                if (coins >= 200)
                {
                    coins -= 200;
                    coinsCount++;
                }
                else if (coins >= 100)
                {
                    coins -= 100;
                    coinsCount++;
                }
                else if (coins >= 50)
                {
                    coins -= 50;
                    coinsCount++;
                }
                else if (coins >= 20)
                {
                    coins -= 20;
                    coinsCount++;
                }
                else if (coins >= 10)
                {
                    coins -= 10;
                    coinsCount++;
                }
                else if (coins >= 5)
                {
                    coins -= 5;
                    coinsCount++;
                }
                else if (coins >= 2)
                {
                    coins -= 2;
                    coinsCount++;
                }
                else if (coins >= 1)
                {
                    coins -= 1;
                    coinsCount++;
                }
            }
            Console.WriteLine(coinsCount);
        }
    }
}
