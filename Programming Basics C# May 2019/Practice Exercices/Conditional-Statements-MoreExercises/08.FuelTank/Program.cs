using System;

namespace _08.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            fuelType = fuelType.ToLower();
            double tankLiters = double.Parse(Console.ReadLine());


            if (!(fuelType == "diesel" || fuelType == "gasoline" || fuelType == "gas"))
            {
                Console.WriteLine("Invalid fuel!");
            }
            else if (tankLiters >= 25)
            {
                Console.WriteLine($"You have enough {fuelType}.");
            }
            else if (tankLiters < 25)
            {
                Console.WriteLine($"Fill your tank with {fuelType}!");
            }
        }
    }
}