using System;

namespace _06.MonthlyExpences
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());

            double otherExpences = 0;

            int water = 20;
            int net = 15;

            double totalWaterPrice = 0;
            double totalNetPrice = 0;
            double totalElectricityPrice = 0;
            double totalOtherPrice = 0;

            for (int i = 0; i < month; i++)
            {
                double electricity = double.Parse(Console.ReadLine());

                otherExpences = electricity + water + net + (0.2 * (electricity + water + net));

                totalElectricityPrice += electricity;
                totalOtherPrice += otherExpences;
            }
            totalWaterPrice = water * month;
            totalNetPrice = net * month;

            double averageExpences = (totalElectricityPrice + totalWaterPrice + totalNetPrice + totalOtherPrice) / month;

            Console.WriteLine($"Electricity: {totalElectricityPrice:f2} lv");
            Console.WriteLine($"Water: {totalWaterPrice:f2} lv");
            Console.WriteLine($"Internet: {totalNetPrice:f2} lv");
            Console.WriteLine($"Other: {totalOtherPrice:f2} lv");
            Console.WriteLine($"Average: {averageExpences:f2} lv");
        }
    }
}
