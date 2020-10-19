using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            turtleFood /= 1000;

            double foodForAll = dogFood + catFood + turtleFood;
            foodForAll *= days;
            double leftFood = Math.Abs(food - foodForAll);

            if (foodForAll <= food)
            {
                Console.WriteLine($"{Math.Floor(leftFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(leftFood)} more kilos of food are needed.");
            }
        }
    }
}
