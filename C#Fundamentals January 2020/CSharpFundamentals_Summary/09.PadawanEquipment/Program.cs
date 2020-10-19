using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sibrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double discount = students / 6;
            double totalSibersPrice = (students + Math.Ceiling(students * 0.1)) * sibrePrice;
            double totalRobesPrice = robePrice * students;
            double totalBeltsPrice = (students - discount) * beltPrice;

            double totalAmount = totalSibersPrice + totalRobesPrice + totalBeltsPrice;

            if (budget < totalAmount)
            {
                Console.WriteLine($"Ivan Cho will need {totalAmount-budget:F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalAmount:F2}lv.");
            }
        }
    }
}
