using System;

namespace WeekDay
{
    class WeekDay
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:Console.WriteLine("Monday"); break;
                case 2:Console.WriteLine("Tuesday"); break;
                case 3:Console.WriteLine("Wednesday"); break;
                case 4:Console.WriteLine("Thursday"); break;
                case 5:Console.WriteLine("Friday"); break;
                case 6:Console.WriteLine("Saturday"); break;
                case 7:Console.WriteLine("Sunday"); break;

                default: Console.WriteLine("The week has only 7 days!"); break;
            }
        }
    }
}
//Ден от седмицата
//Напишете програма, която чете цяло число, въведено от потребителя, и отпечатва ден от седмицата(на
//английски език), в граници[1...7] или отпечатва &quot;Error&quot; в случай, че въведеното число е невалидно.