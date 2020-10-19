using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());//handle number of people per hour by 1 employee
            int secondEmployee = int.Parse(Console.ReadLine());//handle number of people per hour by 1 employee
            int thirdEmployee = int.Parse(Console.ReadLine());//handle number of people per hour by 1 employee
            int totalPeopleCount = int.Parse(Console.ReadLine());

            int totalPeoplePerHour = firstEmployee + secondEmployee + thirdEmployee;
            int neededHours = 0;

            while (totalPeopleCount > 0)
            {
                totalPeopleCount -= totalPeoplePerHour;
                neededHours++;
                if (totalPeopleCount < 0)
                {
                    totalPeopleCount = 0;
                    break;
                }
                if (neededHours % 3 == 0)
                {
                    neededHours++;
                }
            }
            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}
