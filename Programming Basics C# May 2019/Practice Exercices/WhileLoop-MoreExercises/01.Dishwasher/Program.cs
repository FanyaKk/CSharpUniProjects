using System;

namespace WhileLoop_MoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBottles = int.Parse(Console.ReadLine());

            int bottlesQuantity = numberOfBottles * 750;

            int plateCount = 0;
            int saucepanCount = 0;
            int loading = 0;
            int usedDetergent = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                int dishes = int.Parse(command);
                loading++;

                if (loading % 3 == 0)
                {
                    usedDetergent = 15 * dishes;
                    saucepanCount += dishes;
                }
                else
                {
                    usedDetergent = 5 * dishes;
                    plateCount += dishes;
                }

                bottlesQuantity -= usedDetergent;

                if (bottlesQuantity < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(bottlesQuantity)} ml. more necessary!");
                    break;
                }

                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{plateCount} dishes and {saucepanCount} pots were washed.");
                Console.WriteLine($"Leftover detergent {bottlesQuantity} ml.");
            }
        }
    }
}
