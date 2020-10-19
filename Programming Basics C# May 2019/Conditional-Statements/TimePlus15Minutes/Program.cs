using System;

namespace _05.TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int addMinutes = minutes + 15;


            if(addMinutes > 59)
            {
                hours += 1;
                addMinutes -= 60;
            }
            if(hours == 24)
            {
                hours -= 24;
            }
            if (addMinutes < 10)
            {
                Console.WriteLine($"{hours}:0{addMinutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{addMinutes}");
            }
        }
    }
}
