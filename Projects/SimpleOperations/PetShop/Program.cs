using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogsCount = double.Parse(Console.ReadLine());
            double otherPets = double.Parse(Console.ReadLine());

            double foodAmount = (dogsCount * 2.5) + (otherPets * 4);

            Console.WriteLine($"{foodAmount:f2} lv.");
        }
    }
}
