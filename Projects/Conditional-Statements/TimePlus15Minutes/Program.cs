using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = hours * 60 + minutes;
            int timePlus15 = timeInMinutes + 15;

            hours = timePlus15 / 60;
            minutes = timePlus15 % 60;

            if (hours >= 24) // Ако след прибавяне на 15-те минути полученото число е >= 24
            {
                hours -= 24; // Това е еквивалент на hours = hours - 24, тоест така започва показването на часа от "0"
            }
            if (minutes < 10)
            {
                Console.WriteLine("{0}:0{1}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }
        }
    }
}
//Време + 15 минути
//Да се напише програма, която чете час и минути от 24-часово денонощие, въведени от потребителя и
//изчислява колко ще е часът след 15 минути.Резултатът да се отпечата във формат часове:минути.Часовете

//© Software University Foundation.This work is licensed under the CC-BY-NC-SA license.
//Follow us: Page 11 of 11
//винаги са между 0 и 23, а минутите винаги са между 0 и 59. Часовете се изписват с една или две цифри.
//Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо.