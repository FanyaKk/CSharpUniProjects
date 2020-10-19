using System;

namespace DisneylandJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyCosts = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double savedMoney = 0;
            for (int i = 1; i <= months; i++)
            {               
                if (i % 2 != 0 && i != 1)
                {
                    savedMoney -= savedMoney * 0.16;
                }
                if (i % 4 == 0)
                {
                    savedMoney += savedMoney * 0.25;
                }
                savedMoney += journeyCosts * 0.25;
            }
            if (savedMoney >= journeyCosts)
            {
                double leftMoney = savedMoney - journeyCosts;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {leftMoney:f2}lv. for souvenirs.");
            }
            else
            {
                double needMoney = journeyCosts - savedMoney;
                Console.WriteLine($"Sorry. You need {needMoney:f2}lv. more.");
            }
        }
    }
}
