using System;

namespace _09.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            double examTime = (examHour * 60) + examMinute;
            double arriveTime = (arriveHour * 60) + arriveMinute;
            double difference = examTime - arriveTime;

            double hours = 0;
            double minutes = 0;

            if (difference <= -1)
            {
                if (difference < -59)
                {
                    hours = Math.Truncate(difference / 60);
                    minutes = difference % 60;
                    if (minutes > -10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{Math.Abs(hours)}:0{Math.Abs(minutes)} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{Math.Abs(hours)}:{Math.Abs(minutes)} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
            }
            else if (difference <= 30 && difference >= 0)
            {
                if (difference > 0)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine("On time");
                }
            }
            else if (difference > 30)
            {
                if (difference > 59)
                {
                    hours = Math.Truncate(difference / 60);
                    minutes = difference % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
        }
    }
}