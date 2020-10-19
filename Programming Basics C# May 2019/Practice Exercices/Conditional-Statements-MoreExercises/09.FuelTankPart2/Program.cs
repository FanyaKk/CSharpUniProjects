using System;

namespace _09.FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelLiters = double.Parse(Console.ReadLine());
            string discountClubCard = Console.ReadLine();

            double gasolinePrice = 0;//fuelLiters * 2.22;
            double dieselPrice = 0; //fuelLiters * 2.33;
            double gasPrice = 0; //fuelLiters * 0.93;

            double fuelPrice = 0;

            if (discountClubCard == "Yes")
            {
                gasolinePrice = fuelLiters * (2.22 - 0.18);
                dieselPrice = fuelLiters * (2.33 - 0.12);
                gasPrice = fuelLiters * (0.93 - 0.08);

                if (fuelType == "Gasoline")
                {
                    fuelPrice = gasolinePrice;
                }
                else if (fuelType == "Diesel")
                {
                    fuelPrice = dieselPrice;
                }
                else if (fuelType == "Gas")
                {
                    fuelPrice = gasPrice;
                }
            }
            else if (discountClubCard == "No")
            {
                gasolinePrice = fuelLiters * 2.22;
                dieselPrice = fuelLiters * 2.33;
                gasPrice = fuelLiters * 0.93;

                if (fuelType == "Gasoline")
                {
                    fuelPrice = gasolinePrice;
                }
                else if (fuelType == "Diesel")
                {
                    fuelPrice = dieselPrice;
                }
                else if (fuelType == "Gas")
                {
                    fuelPrice = gasPrice;
                }
            }
            if (20 <= fuelLiters && fuelLiters <= 25)
            {
                fuelPrice *= 0.92;
            }
            else if (fuelLiters > 25)
            {
                fuelPrice *= 0.9;
            }
            Console.WriteLine($"{fuelPrice:f2} lv.");
        }
    }
}
