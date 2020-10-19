using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    price = numberOfPeople * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = numberOfPeople * 9.80;
                }
                else if (day == "Sunday")
                {
                    price = numberOfPeople * 10.46;
                }
                if (numberOfPeople >= 30)
                {
                    price *= 0.85;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    price = numberOfPeople * 10.90;
                }
                else if (day == "Saturday")
                {
                    price = numberOfPeople * 15.60;
                }
                else if (day == "Sunday")
                {
                    price = numberOfPeople * 16;
                }
                if (numberOfPeople >= 100)
                {
                    double priceOfEach = price / numberOfPeople;
                    price -= priceOfEach * 10;
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    price = numberOfPeople * 15;
                }
                else if (day == "Saturday")
                {
                    price = numberOfPeople * 20;
                }
                else if (day == "Sunday")
                {
                    price = numberOfPeople * 22.50;
                }
                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    price *= 0.95;
                }
            }
            decimal finalPrice = (decimal)price;
            Console.WriteLine($"Total price: {finalPrice:F2}");
        }
    }
}
