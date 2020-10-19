using System;

namespace ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            double projectCount = double.Parse(Console.ReadLine());

            double hoursNeeded = projectCount * 3;

            Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {projectCount} project / s");
        }
    }
}
