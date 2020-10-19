using System;

namespace _08.Outing
{
    class Program
    {
        static void Main(string[] args)
        {
            int fishesNumber = int.Parse(Console.ReadLine());
            string fishName = Console.ReadLine();

            int fishesCount = 0;
            double earnMoney = 0;
            double lostMoney = 0;

            while (fishName != "Stop")
            {
                if (fishesNumber > 0)
                {
                    double fishKilograms = double.Parse(Console.ReadLine());

                    double fishPrice = 0;
                    double totalFishPrice = 0;

                    for (int j = 0; j < fishName.Length; j++)
                    {
                        char digit = fishName[j];
                        fishPrice += digit;
                    }
                    totalFishPrice = fishPrice / fishKilograms;
                    fishesCount++;
                    fishesNumber--;

                    if (fishesCount % 3 == 0)
                    {
                        earnMoney += totalFishPrice;
                    }
                    else
                    {
                        lostMoney += totalFishPrice;
                    }
                }
                else if (fishesNumber <= 0)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }
                fishName = Console.ReadLine();
            }
            if (earnMoney > lostMoney)
            {
                earnMoney -= lostMoney;
                Console.WriteLine($"Lyubo's profit from {fishesCount} fishes is {earnMoney:f2} leva.");
            }
            else
            {
                lostMoney -= earnMoney;
                Console.WriteLine($"Lyubo lost {lostMoney:f2} leva today.");
            }
            //int fishesNumber = int.Parse(Console.ReadLine());
            //string fishName = "";

            //int fishesCount = 0;
            //double earnMoney = 0;
            //double lostMoney = 0;

            //while (fishName != "Stop")
            //{
            //    if (fishesNumber > 0)
            //    {
            //        fishName = Console.ReadLine();
            //        if (fishName == "Stop")
            //        {
            //            break;
            //        }
            //        double fishKilograms = double.Parse(Console.ReadLine());

            //        double fishPrice = 0;
            //        double totalFishPrice = 0;

            //        for (int j = 0; j < fishName.Length; j++)
            //        {
            //            fishPrice += fishName[j];
            //        }
            //        totalFishPrice = fishPrice / fishKilograms;
            //        fishesCount++;

            //        if (fishesCount % 3 == 0)
            //        {
            //            earnMoney += totalFishPrice;
            //        }
            //        else
            //        {
            //            lostMoney += totalFishPrice;
            //        }
            //    }
            //    if (fishesNumber == fishesCount)
            //    {
            //        Console.WriteLine("Lyubo fulfilled the quota!");
            //        break;
            //    }
            //}
            //if (earnMoney >= lostMoney)
            //{
            //    earnMoney -= lostMoney;
            //    Console.WriteLine($"Lyubo's profit from {fishesCount} fishes is {earnMoney:f2} leva.");
            //}
            //else
            //{
            //    lostMoney -= earnMoney;
            //    Console.WriteLine($"Lyubo lost {lostMoney:f2} leva today.");
            //}
        }
    }
}