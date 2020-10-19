using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeterForGreening = double.Parse(Console.ReadLine());

            double servicePrice = squareMeterForGreening * 7.61;
            double discount = servicePrice * 0.18;
            double totalPrice = servicePrice - discount;

            Console.WriteLine($"The final price is: {totalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
