using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double places = rows * columns;
            double income = 0;

            if (projection == "Premiere")
            {
                Console.WriteLine("{0:f2} leva.", income = places * 12);
            }
            else if (projection == "Normal")
            {
                Console.WriteLine("{0:f2} leva.", income = places * 7.5);
            }
            else if (projection == "Discount")
            {
                Console.WriteLine("{0:f2} leva.", income = places * 5);
            }
        }
    }
}
//В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони.Има три вида прожекции
//с билети на различни цени:
// Premiere – премиерна прожекция, на цена 12.00 лева.
// Normal – стандартна прожекция, на цена 7.50 лева.
// Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
//Напишете програма, която чете тип прожекция(стринг), брой редове и брой колони в залата(цели числа),
//въведени от потребителя, и изчислява общите приходи от билети при пълна зала.Резултатът да се отпечата
//във формат като в примерите по-долу, с 2 знака след десетичната точка.