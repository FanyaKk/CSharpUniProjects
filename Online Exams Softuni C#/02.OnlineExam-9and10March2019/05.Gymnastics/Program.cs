using System;

namespace _05.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string appliance = Console.ReadLine();

            double score = 0;

            if (country == "Russia")
            {
                if (appliance == "ribbon")
                {
                    score = 18.5;
                }
                else if (appliance == "hoop")
                {
                    score = 19.1;
                }
                else if (appliance == "rope")
                {
                    score = 18.6;
                }
            }
            else if (country == "Bulgaria")
            {
                if (appliance == "ribbon")
                {
                    score = 19;
                }
                else if (appliance == "hoop")
                {
                    score = 19.3;
                }
                else if (appliance == "rope")
                {
                    score = 18.9;
                }
            }
            else if (country == "Italy")
            {
                if (appliance == "ribbon")
                {
                    score = 18.7;
                }
                else if (appliance == "hoop")
                {
                    score = 18.8;
                }
                else if (appliance == "rope")
                {
                    score = 18.85;
                }
            }
            double neededScoreToMaxResult = 100 - (score / 20 * 100);

            Console.WriteLine($"The team of {country} get {score:f3} on {appliance}.");
            Console.WriteLine($"{neededScoreToMaxResult:f2}%");
        }
    }
}
