using System;

namespace _05Coins
{
    class Coins
    {
        static void Main(string[] args)
        {
            //Ex. 1

            decimal change = decimal.Parse(Console.ReadLine()); // ако променливата е дефинирана с "double", а не с decimal, при числата по малки от 1-ца, се появява като проблем точостта на double и тогава трябва да закръгли резултата с Math.Floor -> change = Math.Floor(change * 100);
            change *= 100; // Рестото в стотинки ---- (change = Math.Floor(change * 100);)
            int countCoins = 0;
            while (change > 0)
            {
                if (change >= 200)
                {
                    change -= 200;
                    countCoins++;
                }
                else if (change >= 100)
                {
                    change -= 100;
                    countCoins++;
                }
                else if (change >= 50)
                {
                    change -= 50;
                    countCoins++;
                }
                else if (change >= 20)
                {
                    change -= 20;
                    countCoins++;
                }
                else if (change >= 10)
                {
                    change -= 10;
                    countCoins++;
                }
                else if (change >= 5)
                {
                    change -= 5;
                    countCoins++;
                }
                else if (change >= 2)
                {
                    change -= 2;
                    countCoins++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    countCoins++;
                }
            }
            Console.WriteLine(countCoins);

            //Ex. 2
            //double change = double.Parse(Console.ReadLine());
            //double reset = change * 100;
            //int countCoins = 0;

            //while (reset >= 200)
            //{
            //    reset -= 200;
            //    countCoins++;
            //}
            //while (reset >= 100)
            //{
            //    reset -= 100;
            //    countCoins++;
            //}
            //while (reset >= 50)
            //{
            //    reset -= 50;
            //    countCoins++;
            //}
            //while (reset >= 20)
            //{
            //    reset -= 20;
            //    countCoins++;
            //}
            //while (reset >= 10)
            //{
            //    reset -= 10;
            //    countCoins++;
            //}
            //while (reset >= 5)
            //{
            //    reset -= 5;
            //    countCoins++;
            //}
            //while (reset >= 2)
            //{
            //    reset -= 2;
            //    countCoins++;
            //}
            //while (reset >= 1)
            //{
            //    reset -= 1;
            //    countCoins++;
            //}
            //Console.WriteLine(countCoins);
        }
    }
}
