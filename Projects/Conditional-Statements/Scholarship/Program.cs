using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете месечен доход в лева!");
            double incomeOfAMember = double.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете среден успех на ученика!");
            double averageSuccess = double.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете минималната работна заплата!");
            double minimalSalary = double.Parse(Console.ReadLine());

            double socialScholarship = minimalSalary * 0.35;
            double successScholarship = averageSuccess * 25;

        
            if (incomeOfAMember <= minimalSalary)
            {
                if (averageSuccess >= 4.5)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
                }
                else if (averageSuccess >= 5.5)
                {
                    if (socialScholarship > successScholarship)
                    {
                        Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
                    }
                    else if (socialScholarship <= successScholarship)
                    {
                        Console.WriteLine("You get a scholarship for excellents results {0} BGN", successScholarship);
                    }
                }
                else if (averageSuccess >= 5.5)
                {
                    Console.WriteLine("You get a scholarship for excellents results {0} BGN", successScholarship);
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
        }
    }
}
//* Стипендии
//Учениците могат да кандидатстват за социална стипендия или за стипендия за отличен успех.Изискване за
//социална стипендия - доход на член от семейството по-малък от минималната работна заплата и успех над
//4.5. Размер на социалната стипендия - 35% от минималната работна заплата.Изискване за стипендия за
//отличен успех - успех над 5.5, включително.Размер на стипендията за отличен успех - успехът на ученика,
//умножен по коефициент 25.
//Напишете програма, която при въведени доход, успех и минимална работна заплата, дава информация дали
//ученик има право да получава стипендия, и стойността на стипендията, която е по-висока за него.
//Вход
//Потребителят въвежда 3 числа, по едно на ред:
//1. Доход в лева - реално число в интервала [0.00..6000.00]
//2. Среден успех - реално число в интервала [2.00...6.00]
//3. Минимална работна заплата - реално число в интервала [0.00..1000.00]
//Изход
// Ако ученикът няма право да получава стипендия, се извежда:
//&quot; You cannot get a scholarship!&quot;
// Ако ученикът има право да получава само социална стипендия:

//© Software University Foundation.This work is licensed under the CC-BY-NC-SA license.
//Follow us: Page 11 of 11

//&quot; You get a Social scholarship {стойност на стипендия} BGN&quot;
// Ако ученикът има право да получава само стипендия за отличен успех:
//&quot;You get a scholarship for excellent results { стойност на стипендията }
//BGN&quot;
// Ако ученикът има право да получава и двата типа стипендии, ще получи по-голямата по сума, а ако
//са равни ще получи тази за отличен успех.
//Резултатът се закръгля до по-малкото цяло число.