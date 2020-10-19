using System;

namespace _07.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsNumbers = int.Parse(Console.ReadLine());
            double initialSalary = double.Parse(Console.ReadLine());

            double salary = initialSalary;

            int totalPenalty = 0;

            for (int i = 0; i < tabsNumbers; i++)
            {
                string websiteName = Console.ReadLine();

                if (websiteName == "Facebook")
                {
                    initialSalary -= 150;
                    totalPenalty += 150;
                }
                else if (websiteName == "Instagram")
                {
                    initialSalary -= 100;
                    totalPenalty += 100;
                }
                else if (websiteName == "Reddit")
                {
                    initialSalary -= 50;
                    totalPenalty += 50;
                }
                if (initialSalary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            double leftMoney = salary - totalPenalty;
            Console.WriteLine($"{leftMoney:f0}");
        }
    }
}
