using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
//Проверка за отлична оценка
//Първата задача от тази тема е да се напише конзолна програма, която чете оценка(десетично число),
//въведена от потребителя и отпечатва &quot;Excellent!&quot;, ако оценката е 5.50 или по-висока.