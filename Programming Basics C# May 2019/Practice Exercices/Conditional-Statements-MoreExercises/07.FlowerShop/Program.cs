using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolia = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cacti = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double orderValue = ((magnolia * 3.25) + (hyacinths * 4) + (roses * 3.5) + (cacti * 8)) * 0.95;
            double leftMoney = Math.Abs(orderValue - presentPrice);

            if (presentPrice <= orderValue)
            {
                Console.WriteLine($"She is left with {Math.Floor(leftMoney)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(leftMoney)} leva.");
            }
        }
    }
}