using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacancySeason = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double nightsPrice = 0;
            string sportType = "";

            if (vacancySeason == "Winter")
            {
                if (groupType == "boys")
                {
                    sportType = "Judo";
                    nightsPrice = nights * students * 9.60;
                }
                else if (groupType == "girls")
                {
                    sportType = "Gymnastics";
                    nightsPrice = nights * students * 9.60;
                }
                else if (groupType == "mixed")
                {
                    sportType = "Ski";
                    nightsPrice = nights * students * 10;
                }
            }
            else if (vacancySeason == "Spring")
            {
                if (groupType == "boys")
                {
                    sportType = "Tennis";
                    nightsPrice = nights * students * 7.20;
                }
                else if (groupType == "girls")
                {
                    sportType = "Athletics";
                    nightsPrice = nights * students * 7.20;
                }
                else if (groupType == "mixed")
                {
                    sportType = "Cycling";
                    nightsPrice = nights * students * 9.50;
                }
            }
            else if (vacancySeason == "Summer")
            {
                if (groupType == "boys")
                {
                    sportType = "Football";
                    nightsPrice = nights * students * 15;
                }
                else if (groupType == "girls")
                {
                    sportType = "Volleyball";
                    nightsPrice = nights * students * 15;
                }
                else if (groupType == "mixed")
                {
                    sportType = "Swimming";
                    nightsPrice = nights * students * 20;
                }
            }
            if (students >= 50)
            {
                nightsPrice *= 0.5;
            }
            else if (students >= 20)
            {
                nightsPrice *= 0.85;
            }
            else if (students >= 10)
            {
                nightsPrice *= 0.95;
            }
            Console.WriteLine($"{sportType} {nightsPrice:f2} lv.");
        }
    }
}