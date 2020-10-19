using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = new string[7] { //Тук очаква точно 7 string-а които да бъдат запазени в масива.
                "Monday",                        //Ако в скобите след new string няма число, както е подадено в ред 16, 
                "Tuesday",                       //тогава в масива ще има толкова на брой string-а колкото му бъдат подадени в къдравоте скоби {}
                "Wednesday",
                "Thursday", "Friday",
                "Saturday",
                "Sunday" };
            //string[] dayOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());
            if (input >= 1 && input <= 7)
            {
                Console.WriteLine(dayOfWeek[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
