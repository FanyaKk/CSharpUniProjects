using System;

namespace Choreographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = int.Parse(Console.ReadLine());
            double dancers = int.Parse(Console.ReadLine());
            double days = int.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling((steps / days) / steps * 100);// Първо изчисляваме по колко стъпки се падат на ден от общият им брой. Това става, като разделим броя на стъпките на броя на дните. За да запазим резултата във променливата "StepsPerDays" като проценти, трябва да го разделим на броя на всички стъпки и да го умножим по 100.
            double stepsPerDancers = stepsPerDay / dancers; //Тук изчисляваме броя стъпки на ден за всеки танцьор по отделно. За целта разделяме полученият резултат от "StepsPerDay" (брой стъпки за един ден) на броя на танцьорите!

            if (stepsPerDancers <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal!{0:f2}%", stepsPerDancers);
            }
            else
            {
                Console.WriteLine("Yes, they will not succeed in that goal! Reguired {0:f2}% steps to be learned per day", stepsPerDancers);
            }
        }
    }
}
//Хореография
//Група танцьори се подготвя за финално състезание.Те трябва да научат нова хореография.Танцът се състои
//от N - на брой стъпки, които се разпределят между танцьорите.Цялата хореография трябва да се научи за
//определен брой дни. Всички танцьори могат да научат не повече от 13% от общите стъпки на ден.Да се
//напише програма която пресмята дали танцьорите ще успеят да научат новия танц и по колко процента от
//стъпките следва да научи всеки един от тях.
//При изчисляване на процента стъпки на ден, числото трябва да се закръгли към най - близкото цяло число
//нагоре.

//© Software University Foundation.This work is licensed under the CC-BY-NC-SA license.
//Follow us: Page 11 of 11

//Вход
//От конзолата се четат 3 реда:
//1. Брой стъпки - цяло число в интервала [1 … 100 000]
//2. Брой танцьори - цяло число в интервала [1 … 50]
//3. Брой дни за учене - цяло число в интервала [1 … 31]
//Изход
//Отпечатването на конзолата зависи от резултата:
// Ако общият процент стъпки са по-малко или равни на 13% отпечатваме:
//o &quot; Yes, they will succeed in that goal! {процент стъпки които трябва да научи всеки
// един танцьор на ден}%.&quot;

// Ако общият процент стъпки са повече от 13% отпечатваме:
//o &quot;No, they will not succeed in that goal! Required {процент стъпки, които
//трябва да научи всеки един танцьор на ден}% steps to be learned per day.&quot;

//И двата отговора трябва да са форматирани до втория знак след десетичната запетая.