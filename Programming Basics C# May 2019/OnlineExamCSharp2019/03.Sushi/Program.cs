using System;

namespace _03.Sushi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restaurantName = Console.ReadLine();
            int numberOfPortion = int.Parse(Console.ReadLine());
            char deliveryType = char.Parse(Console.ReadLine());

            double purchasePrice = 0;
            double deliveryPrice = 0;

            bool validName = false;

            if(restaurantName == "Sushi Zone")
            {
                validName = true; ;
                if (sushiType == "sashimi")
                {
                    purchasePrice = 4.99 * numberOfPortion;
                }
                else if (sushiType == "maki")
                {
                    purchasePrice = 5.29 * numberOfPortion;
                }
                else if (sushiType == "uramaki")
                {
                    purchasePrice = 5.99 * numberOfPortion;
                }
                else if (sushiType == "temaki")
                {
                    purchasePrice = 4.29 * numberOfPortion;
                }
            }
            else if (restaurantName == "Sushi Time")
            {
                validName = true;
                if (sushiType == "sashimi")
                {
                    purchasePrice = 5.49 * numberOfPortion;
                }
                else if (sushiType == "maki")
                {
                    purchasePrice = 4.69 * numberOfPortion;
                }
                else if (sushiType == "uramaki")
                {
                    purchasePrice = 4.49 * numberOfPortion;
                }
                else if (sushiType == "temaki")
                {
                    purchasePrice = 5.19 * numberOfPortion;
                }
            }
            else if (restaurantName == "Sushi Bar")
            {
                validName = true;
                if (sushiType == "sashimi")
                {
                    purchasePrice = 5.29 * numberOfPortion;
                }
                else if (sushiType == "maki")
                {
                    purchasePrice = 5.55 * numberOfPortion;
                }
                else if (sushiType == "uramaki")
                {
                    purchasePrice = 6.25 * numberOfPortion;
                }
                else if (sushiType == "temaki")
                {
                    purchasePrice = 4.75 * numberOfPortion;
                }
            }
            else if (restaurantName == "Asian Pub")
            {
                validName = true;
                if (sushiType == "sashimi")
                {
                    purchasePrice = 4.50 * numberOfPortion;
                }
                else if (sushiType == "maki")
                {
                    purchasePrice = 4.80 * numberOfPortion;
                }
                else if (sushiType == "uramaki")
                {
                    purchasePrice = 5.50 * numberOfPortion;
                }
                else if (sushiType == "temaki")
                {
                    purchasePrice = 5.50 * numberOfPortion;
                }
            }
            if (validName == false)
            {
                Console.WriteLine($"{restaurantName} is invalid restaurant!");
            }
            else if (deliveryType == 'Y' && validName == true)
            {
                deliveryPrice = purchasePrice * 0.2;
                purchasePrice += deliveryPrice;
                Console.WriteLine($"Total price: {Math.Ceiling(purchasePrice)} lv.");
            }
            else if (deliveryType == 'N' && validName == true)
            {
                Console.WriteLine($"Total price: {Math.Ceiling(purchasePrice)} lv.");
            }
        }
    }
}
