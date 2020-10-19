using System;

namespace PersonalTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    price = quantity * 0.50;
                    Console.WriteLine(price);
                }
                else if (city == "Plovdiv")
                {
                    price = quantity * 0.40;
                    Console.WriteLine(price);
                }
                else if (city == "Varna")
                {
                    price = quantity * 0.45;
                    Console.WriteLine(price);
                }
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    price = quantity * 0.80;
                    Console.WriteLine(price);
                }
                else if (city == "Plovdiv")
                {
                    price = quantity * 0.70;
                    Console.WriteLine(price);
                }
                else if (city == "Varna")
                {
                    price = quantity * 0.70;
                    Console.WriteLine(price);
                }
            }
            if (product == "beer")
            {
                if (city == "Sofia")
                {
                    price = quantity * 1.20;
                    Console.WriteLine(price);
                }
                else if (city == "Plovdiv")
                {
                    price = quantity * 1.15;
                    Console.WriteLine(price);
                }
                else if (city == "Varna")
                {
                    price = quantity * 1.10;
                    Console.WriteLine(price);
                }
            }
            if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    price = quantity * 1.45;
                    Console.WriteLine(price);
                }
                else if (city == "Plovdiv")
                {
                    price = quantity * 1.30;
                    Console.WriteLine(price);
                }
                else if (city == "Varna")
                {
                    price = quantity * 1.35;
                    Console.WriteLine(price);
                }
            }
            if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    price = quantity * 1.60;
                    Console.WriteLine(price);
                }
                else if (city == "Plovdiv")
                {
                    price = quantity * 1.50;
                    Console.WriteLine(price);
                }
                else if (city == "Varna")
                {
                    price = quantity * 1.55;
                    Console.WriteLine(price);
                }
            }
        }
    }
}
