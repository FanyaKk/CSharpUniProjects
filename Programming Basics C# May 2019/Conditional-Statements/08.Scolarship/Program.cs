using System;

namespace _08.Scolarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimumSelary = double.Parse(Console.ReadLine());

            double socialScolarship = Math.Floor(minimumSelary * 0.35);
            double successScolarship = Math.Floor(averageSuccess * 25);


            if (income < minimumSelary && averageSuccess >= 5.5)
            {
                if (successScolarship >= socialScolarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {successScolarship} BGN");
                }
                else if (socialScolarship > successScolarship)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
                }
            }
            else if (income < minimumSelary && averageSuccess > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            }
            else if (averageSuccess >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {successScolarship} BGN");
            }
            else
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
        }
    }
}