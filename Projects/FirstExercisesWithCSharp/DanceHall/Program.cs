using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double Wardrobe = (A * 100) * (A * 100);
            double hallArea = (L * 100) * (W * 100);
            double benchArea = hallArea / 10;
            double totalHallArea = hallArea - Wardrobe - benchArea;
            double dancersCount = Math.Floor((totalHallArea) / (40+7000));//Math.Floor се използва за закръгляне надолу до най-близкото получено число.

            Console.WriteLine(dancersCount);
        }
    }
}
//Група танцьори си търсят нова зала.Залата, която са харесали, е правоъгълна и има размери:
//L - дължина и W - ширина (в метри). В залата има квадратен гардероб със страна - A и правоъгълна скамейка
//с площ 10 пъти по-малка от площта на залата.
//Мястото, което заема един танцьор е 40 см² и допълнително за свободно движение му трябват още 7000см².
//Напишете програма, която да изчислява колко танцьори могат да се поберат в залата и да се движат
//свободно.
//Полученият резултат трябва да се закръгли до най-близкото цяло число надолу.