using System;

namespace _01.SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSouvenirs = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());

            double travellingPrice = 4.2 * 7 * 1.85;

            double firstDay = moneyForHotel * 0.9;
            double secondDay = moneyForHotel * 0.85;
            double thirdDay = moneyForHotel * 0.8;

            moneyForHotel = firstDay + secondDay + thirdDay;
            moneyForFood *= 3;
            moneyForSouvenirs *= 3;

            double totalMoney = travellingPrice + moneyForFood + moneyForSouvenirs + moneyForHotel;

            Console.WriteLine($"Money needed: {totalMoney:f2}");
        }
    }
}
