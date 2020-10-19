using System;

namespace _06.FootballSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballTeam = Console.ReadLine();
            string souvenirType = Console.ReadLine();
            int numberOfSouvenirs = int.Parse(Console.ReadLine());

            double price = 0;

            if (footballTeam == "Argentina")
            {
                if (souvenirType == "flags")
                {
                    price = numberOfSouvenirs * 3.25;
                }
                else if (souvenirType == "caps")
                {
                    price = numberOfSouvenirs * 7.20;
                }
                else if (souvenirType == "posters")
                {
                    price = numberOfSouvenirs * 5.10;
                }
                else if (souvenirType == "stickers")
                {
                    price = numberOfSouvenirs * 1.25;
                }
            }
            else if (footballTeam == "Brazil")
            {
                if (souvenirType == "flags")
                {
                    price = numberOfSouvenirs * 4.20;
                }
                else if (souvenirType == "caps")
                {
                    price = numberOfSouvenirs * 8.50;
                }
                else if (souvenirType == "posters")
                {
                    price = numberOfSouvenirs * 5.35;
                }
                else if (souvenirType == "stickers")
                {
                    price = numberOfSouvenirs * 1.20;
                }
            }
            else if (footballTeam == "Croatia")
            {
                if (souvenirType == "flags")
                {
                    price = numberOfSouvenirs * 2.75;
                }
                else if (souvenirType == "caps")
                {
                    price = numberOfSouvenirs * 6.90;
                }
                else if (souvenirType == "posters")
                {
                    price = numberOfSouvenirs * 4.95;
                }
                else if (souvenirType == "stickers")
                {
                    price = numberOfSouvenirs * 1.10;
                }
            }
            else if (footballTeam == "Denmark")
            {
                if (souvenirType == "flags")
                {
                    price = numberOfSouvenirs * 3.10;
                }
                else if (souvenirType == "caps")
                {
                    price = numberOfSouvenirs * 6.50;
                }
                else if (souvenirType == "posters")
                {
                    price = numberOfSouvenirs * 4.80;
                }
                else if (souvenirType == "stickers")
                {
                    price = numberOfSouvenirs * 0.90;
                }
            }
            if (footballTeam != "Argentina" && footballTeam != "Brazil" && footballTeam != "Croatia" && footballTeam != "Denmark")
            {
                Console.WriteLine("Invalid country!");
            }
            else if (souvenirType != "flags" && souvenirType != "caps" && souvenirType != "posters" && souvenirType != "stickers")
            {
                Console.WriteLine("Invalid stock!");
            }
            else
            {
                Console.WriteLine($"Pepi bought {numberOfSouvenirs} {souvenirType} of {footballTeam} for {price:f2} lv.");
            }
        }
    }
}
