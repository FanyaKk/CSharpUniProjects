using System;

namespace Graduation
{
    class Graduation
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int count = 1;
            double sum = 0;

            while (count <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum += grade;
                    count++;
                }
            }
            double averageGrade = sum / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
//Завършване

//Напишете програма, която изчислява средната оценка на ученик от цялото му обучение.На първия ред ще
//получите името на ученика, а на всеки следващ ред неговите годишни оценки. Ученикът преминава в
//следващия клас, ако годишната му оценка е по-голяма или равна на 4.00. Ако оценката му е под 4.00, той
//ще повтори класа.
//При успешно завършване на 12-ти клас да се отпечата:
//&quot;{име на ученика} graduated.Average grade: {средната оценка от цялото обучение}&quot;
//Стойността трябва да бъде форматирана до втория знак след десетичната запетая.
//using System;

//namespace _06.Graduation
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //            Напишете програма, която изчислява средната оценка на ученик от цялото му обучение.
//            //На първия ред ще получите името на ученика, 
//            //а на всеки следващ ред неговите годишни оценки.Ученикът преминава в следващия клас, 
//            //ако годишната му оценка е по-голяма или равна на 4.00.Ако оценката му е под 4.00, той ще повтори класа.
//            //При успешно завършване на 12 - ти клас да се отпечата:
//            // "{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
//            //Стойността трябва да бъде форматирана до втория знак след десетичната запетая.

//            string studentName = Console.ReadLine();
//            int counter = 1;
//            double grade = 0;
//            double avarageGrade = 0;
//            double sum = 0;

//            while (counter <= 12)
//            {
//                grade = double.Parse(Console.ReadLine());



//                counter++;
//                sum += grade;

//                if (grade < 4)
//                {
//                    sum -= grade;
//                }

//            }
//            avarageGrade = sum / 12;
//            Console.WriteLine($"{studentName} graduated. Average grade: {avarageGrade:F2}");




//        }
//    }
//}