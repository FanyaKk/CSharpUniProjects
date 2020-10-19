﻿using System;

namespace GraduationPart2
{
    class GraduationPart2
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int count = 1;
            double sum = 0;
            double excluded = 0; // тук се пази броя на изключванията
            bool isExcluded = false; // променлива от тип boolian, защото има само 2 опции, ученикът да бъде изключен или да не бъде. По-подразбиране се пази стойност "false", тоест, че не е изключен, ако тази стойност се проемни нa "true" отпечатваме конкретният резултат.

            while (count <= 12)// задаваме стойност на цикъла. Повтарящо се действие до 12 пъти
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum += grade;// към променливата "sum" се добавя въведената оценка и това действие се повтаря при всяка въведена оценка!
                    count++;//след всеки ред прибавя по една бройка към брояча ако въведената оценка е 4 или повече.
                }
                else if (grade < 4)
                {
                    excluded++;//след всеки ред прибавя по една бройка към брояча ако въведената оценка е по-малка от 4, и така до 2 последователни единици < 4!
                }
                if (excluded >=2)//Ако имаме 2 последователни стойности < 4 записа на променливата "isExclided" се променя на "true" цикъла приключва и на екрана не отпечатва зададеният текст.
                {
                    isExcluded = true;
                    break;
                }
            }
            if (isExcluded == false)//Правим проверка-ако променливата "isExcluded" си е запазила записа като "false" отпечатваме даденият текст.
            {
                double average = sum / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {average:f2}");
            }
            else
            {
                Console.WriteLine($"{studentName} has been excluded at {count} grade");
            }
        }
    }
}
//Завършване - част 2

//Напишете програма, която изчислява средната оценка на ученик от цялото му обучение.На първия ред ще
//получите името на ученика, а на всеки следващ ред неговите годишни оценки.Ученикът преминава в
//следващия клас, ако годишната му оценка е по-голяма или равна на 4.00. Ако ученикът бъде скъсан повече
//от един път, то той бива изключен и програмата приключва, като се отпечатва името на ученика и в кой
//клас бива изключен.
//При успешно завършване на 12-ти клас да се отпечата :
//&quot;{име на ученика} graduated.Average grade: {средната оценка от цялото обучение}&quot;
//В случай, че ученикът е изключен от училище, да се отпечата:
//&quot;{име на ученика} has been excluded at { класа, в който е бил изключен }
//grade&quot;
//Стойността трябва да бъде форматирана до втория знак след десетичната запетая.