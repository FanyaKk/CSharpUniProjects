using System;

namespace _03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            string packageType = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceForAllDays = 0;
            double priceForOneDays = 0;

            bool validInput = true;

            if (days < 1)
            {
                validInput = false;
                Console.WriteLine("Days must be positive number!");
            }
            else if (countryName == "Bansko" || countryName == "Borovets")
            {
                if (packageType == "withEquipment")
                {
                    priceForAllDays = days * 100;
                    if (vipDiscount == "yes")
                    {
                        priceForAllDays *= 0.90;
                    }
                }
                else if (packageType == "noEquipment")
                {
                    priceForAllDays = days * 80;
                    if (vipDiscount == "yes")
                    {
                        priceForAllDays *= 0.95;
                    }
                }
                else if (packageType != "withEquipment" || packageType != "noEquipment")
                {
                    validInput = false;
                    Console.WriteLine("Invalid input!");
                }
            }
            else if (countryName == "Varna" || countryName == "Burgas")
            {
                if (packageType == "withBreakfast")
                {
                    priceForAllDays = days * 130;
                    if (vipDiscount == "yes")
                    {
                        priceForAllDays *= 0.88;
                    }
                }
                else if (packageType == "noBreakfast")
                {
                    priceForAllDays = days * 100;
                    if (vipDiscount == "yes")
                    {
                        priceForAllDays *= 0.93;
                    }
                }
                else if (packageType != "withBreakfast" || packageType != "noBreakfast")
                {
                    validInput = false;
                    Console.WriteLine("Invalid input!");
                }
            }
            else if ((countryName != "Bansko" || countryName != "Borovets" || countryName != "Varna" || countryName != "Burgas") && validInput == true)
            {
                validInput = false;
                Console.WriteLine("Invalid input!");
            }
            priceForOneDays = priceForAllDays / days;
            if (days > 7)
            {
                priceForAllDays -= priceForOneDays;
            }
            if (validInput == true)
            {
                Console.WriteLine($"The price is {priceForAllDays:f2}lv! Have a nice time!");
            }
        }
    }
}
