using System;

namespace NumberInRange
{
    class NumberInRange
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {number}");

            // Console.Write("Please enter a numbre between 1 and 100:");
            //int number = int.Parse(Console.ReadLine());
            //bool isInRange = number >= 1 || number <= 100;

            //while (!isInRange)
            //{
            //    Console.WriteLine("Invalid number");

            // Console.Write("Please enter a numbre between 1 and 100:");
            //    number = int.Parse(Console.ReadLine());
            //    isInRange = number >= 1 || number <= 100;
            //}
            //Console.WriteLine($"The number is: {number}");

            //int number = int.Parse(Console.ReadLine());

            //while (number > 100 || number <= 0)
            //{
            //    Console.WriteLine("Invalid number");

            //    number = int.Parse(Console.ReadLine());
            //    if (number > 0 && number <= 100)
            //    {
            //        Console.WriteLine($"The number is:{number}");
            //        break;
            //    }
            //}
        }
    }
}
//Число в диапазона[1…100]

//Напишете програма, която въвежда цяло положително число n в диапазона[1…100]. При въвеждане на
//число извън посочения диапазон, да се отпечата съобщение за грешка и да се въведе ново число.