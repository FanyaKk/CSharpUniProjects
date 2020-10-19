using System;

namespace _01.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double sneakers = annualFee * 0.6;
            double outfit = sneakers * 0.8;
            double ball = outfit / 4;
            double accessories = ball / 5;

            double totalFee = annualFee + sneakers + outfit + ball + accessories;

            Console.WriteLine($"{totalFee:f2}");
        }
    }
}
