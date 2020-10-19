using System;

namespace _03.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (10 <= degrees && degrees <= 18)
            {
                if (dayTime == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (dayTime == "Afternoon" | dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (18 < degrees && degrees <= 24)
            {
                if (dayTime == "Morning" || dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins"; 
                }
                else if (dayTime == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals"; 
                }
            }
            else if (25 <= degrees)
            {
                if (dayTime == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals"; 
                }
                else if (dayTime == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins"; 
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}