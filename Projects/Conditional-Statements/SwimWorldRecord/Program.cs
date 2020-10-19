using System;

namespace SwimWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double timeForAllMeters = distanceInMeters * timeForOneMeter;
            double extraTimeInEvery15Meters = Math.Floor((distanceInMeters / 15) * 12.5);
            double totalTimeInSeconds = timeForAllMeters + extraTimeInEvery15Meters;

            double timeDifference = Math.Abs(totalTimeInSeconds - worldRecord);


            //double newRecord = worldRecord - (metersForSwimming * timeForSwim1Meter);

            if (worldRecord >= totalTimeInSeconds)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0} seconds", totalTimeInSeconds);
            }
            else
            {
                Console.WriteLine("No, he failed!He was {0} seconds slower.", timeDifference);
            }
        }
    }
}
//Световен рекорд по плуване
//Иван решава да подобри Световния рекорд по плуване на дълги разстояния.На конзолата се въвежда
//рекордът в секунди, който Иван трябва да подобри, разстоянието в метри, което трябва да преплува и
//времето в секунди, за което плува разстояние от 1 м.Да се напише програма, която изчислява дали се е
//справил със задачата, като се има предвид, че: съпротивлението на водата го забавя на всеки 15 м.с 12.5
//секунди.Когато се изчислява колко пъти Иванчо ще се забави, в резултат на съпротивлението на водата,
//резултатът трябва да се закръгли надолу до най-близкото цяло число.
//Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо
//Световния рекорд.
//Вход
//От конзолата се четат 3 реда:
//1. Рекордът в секунди – реално число в интервала [0.00 … 100000.00]

//© Software University Foundation.This work is licensed under the CC-BY-NC-SA license.
//Follow us: Page 11 of 11

//2. Разстоянието в метри – реално число в интервала [0.00 … 100000.00]
//3. Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала [0.00 … 1000.00]
//Изход
//Отпечатването на конзолата зависи от резултата:
// Ако Иван е подобрил Световния рекорд отпечатваме:
//o &quot; Yes, he succeeded! The new world record is {времето на Иван} seconds.&quot;
// Ако НЕ е подобрил рекорда отпечатваме:
//o &quot;No, he failed! He was { недостигащите секунди }
//seconds slower.&quot;

//Резултатът трябва да се форматира до втория знак след десетичната запетая.