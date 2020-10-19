using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysCount = double.Parse(Console.ReadLine());
            double bakersCount = double.Parse(Console.ReadLine());
            double cakesCount = double.Parse(Console.ReadLine());
            double wafersCount = double.Parse(Console.ReadLine());
            double pancakesCount = double.Parse(Console.ReadLine());

            double cakesTotalPrice = daysCount * bakersCount * cakesCount * 45;
            double wafersTotalPrice = daysCount * bakersCount * wafersCount * 5.80;
            double pancakesTotalPrice = daysCount * bakersCount * pancakesCount * 3.20;

            double totalPrice = cakesTotalPrice + wafersTotalPrice + pancakesTotalPrice;
            double sumCharityCampaign = totalPrice * 0.875;

            Console.WriteLine($"{sumCharityCampaign:f2}");
        }
    }
}
