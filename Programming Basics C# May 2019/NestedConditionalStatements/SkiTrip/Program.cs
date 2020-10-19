using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double nights = days - 1;
            double discount = 0;

            if (nights < 10)
            {
                if (roomType == "apartment")
                {
                    discount = nights * 25 * 0.7;
                }
                else if (roomType == "president apartment")
                {
                    discount = nights * 35 * 0.9;
                }
                else
                {
                    discount = nights * 18;
                }
            }
            else if (nights <= 15)
            {
                if (roomType == "apartment")
                {
                    discount = nights * 25 * 0.65;
                }
                else if (roomType == "president apartment")
                {
                    discount = nights * 35 * 0.85;
                }
                else
                {
                    discount = nights * 18;
                }
            }
            else if (nights > 15)
            {
                if (roomType == "apartment")
                {
                    discount = nights * 25 * 0.5;
                }
                else if (roomType == "president apartment")
                {
                    discount = nights * 35 * 0.8;
                }
                else
                {
                    discount = nights * 18;
                }
            }
            if (evaluation == "positive")
            {
                discount += discount * 0.25;
            }
            else if (evaluation == "negative")
            {
                discount -= discount * 0.1;
            }
            Console.WriteLine($"{discount:f2}");
        }
    }
}
