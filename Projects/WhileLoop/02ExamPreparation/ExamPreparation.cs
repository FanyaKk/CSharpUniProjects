using System;

namespace _02ExamPreparation
{
    class ExamPreparation
    {
        static void Main(string[] args)
        {
            //Ex. 3
            int inputOfBadGrades = int.Parse(Console.ReadLine()); 
            string taskName = Console.ReadLine(); // низ от който се чете въведеното име на задачата
            string lastTask = string.Empty; // низ е който се пази последното въведено име на задача
            int counterOfBadGrades = 0;// брояч на незадоволителните оценки
            int counterForGrades = 0; //необходим ни е брояч на всички задачи за да можем да пресметнем средната оценка на всички въведени задачи при въвеждане на команда "Enough"!
            double sumGrades = 0;// променлива, в която ще се пази резултата от сбора на всички въведени оценки.

            //bool isReachInputOfBadGrades = false; Проверката може да се извършва и чез добавяне на булева стойност за достигане максималният брой на незадоволителните оценки .В началато флага е "false"

            while (taskName != "Enough")// Докато името на задачата е различно от "Enough"
            {
                int grade = int.Parse(Console.ReadLine());// Всеки път в цикъла четем оценка. В цикъла е, защото ако първото въведено име на задчата е "Enough" не трябва да ни чете оценка а да изведем изхода на задачата, който е дефиниран при taskName == "Enough"!
                sumGrades += grade;// Тъй като ни е необходима средна оценка на всички въведени задачи, имаме добавена променлива "sumGrades" в която сумираме всички въведени оценки "grade"
                counterForGrades++;// Брояч на всички въведени оценки.

                if (grade <= 4)// Условие, ако оценката е по-малка или равна на 4, да я броим като незадоволителна!
                {
                    counterOfBadGrades++;// Брояч на незадоволителните оценки
                }
                if (counterOfBadGrades == inputOfBadGrades)// Условие, което да се изпълнява, ако брояча на незадоволителните оценки стане равен на броя на допустимите незадоволителни оценки (inputOfBadGrades)!
                {
                    Console.WriteLine($"You need a break, {counterOfBadGrades} poor grades.");
                    //isReachInputOfBadGrades = true; След като броя на незадоволителните оценки стане равен на въведеният брой във входните данни, променмяме флага на "true"!
                    break;
                }
                lastTask = taskName; // В "lastTask" пазим информацията за "taskName", като записа се заменя с всяка нова задача!
                taskName = Console.ReadLine();// Всеки път след проверката на въведената задача, да четем ново име на задача!
            }
            //if (isReachInputOfBadGrades == false) - Когато излезем от цикъла, проверяваме дали булевата стойност е с флаг "false", ако е то тогава сме получили команда "Enough" и трябва да ни отпечата съответните редове. Но ако булевата стойносто не е равна на "false", то тогава процесът приключва, защото сме получили определеният брой незадоволителни оценки, и това е друг случай в който изхода от конзолата е с разлинен текст!
            if (taskName == "Enough")// Ако е изпълнено условието taskName == "Enough", влизаме в if-a за изпълнение на зададените редове! :)
            {
                double average = sumGrades / counterForGrades; // За да може да получим резултат в десетици, трябва sumGrades да бъде от тип "double" или в "average", делимото число да бъде умножено по 1.0!!!
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {counterForGrades}");
                Console.WriteLine($"Last problem: {lastTask}");
            }


            //Ex. 2
            //int inputOfBadGrades = int.Parse(Console.ReadLine());

            //double sumGrades = 0;
            //double counterForGrades = 0;
            //string lastTask = string.Empty;
            //int countForBadGrades = 0;
            //string nameOfTask = Console.ReadLine();



            //while (nameOfTask != "Enough")
            //{
            //    lastTask = nameOfTask;
            //    int grade = int.Parse(Console.ReadLine());

            //    sumGrades += grade;
            //    counterForGrades++;

            //    if (grade <= 4)
            //    {
            //        countForBadGrades++;
            //    }
            //    if (countForBadGrades == inputOfBadGrades)
            //    {
            //        Console.WriteLine("You need a break, {0} poor grades.", countForBadGrades);
            //        return;
            //    }
            //    nameOfTask = Console.ReadLine();
            //}
            //double average = sumGrades / counterForGrades;

            //Console.WriteLine($"Average score: {average:f2}");
            //Console.WriteLine($"Number of problems: {counterForGrades}");
            //Console.WriteLine($"Last problem: {lastTask}");





            // Ex. 1 ????
            //string input = string.Empty;

            //while (countForBadGrades < inputOfBadGrades)
            //{
            //    int grade = int.Parse(Console.ReadLine());


            //    if (nameOfTask != "Enough")
            //    {
            //        sumGrades += grade;
            //        counterForGrades++;
            //        lastTask = nameOfTask;
            //        if (grade <= 4)
            //        {
            //            countForBadGrades++;
            //        }
            //        else if (nameOfTask == "Enough")
            //        {
            //            Console.WriteLine($"Average score: {average:f2}");
            //            Console.WriteLine($"Number of problems: {counterForGrades}");
            //            Console.WriteLine($"Last problem: {lastTask}");
            //            break;
            //        }
            //        //nameOfTask = Console.ReadLine();
            //    }

            //}
            //if (countForBadGrades == inputOfBadGrades)
            //{
            //    Console.WriteLine($"You need a break, {countForBadGrades} poor grades.");
            //}
        }
    }
}
//Подготовка за изпит

//Напишете програма, в която Марин решава задачи от изпити докато не получи съобщение &quot;Enough&quot; от
//лектора си.При всяка решена задача той получава оценка.Програмата трябва да приключи прочитането на
//данни при команда &quot;Enough&quot; или ако Марин получи определения брой незадоволителни оценки.
//Незадоволителна е всяка оценка, която е по-малка или равна на 4.
//Вход
// На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]
// След това многократно се четат по два реда:
//o Име на задача - текст (низ)
//o Оценка - цяло число в интервала [2…6]
//Изход
// Ако Марин стигне до командата "Enough", отпечатайте на 3 реда:
//o &quot;Average score: {средна оценка}&quot;
//o &quot;Number of problems: {броя на всички задачи}&quot;
//o &quot;Last problem: {името на последната задача}&quot;
// Ако получи определеният брой незадоволителни оценки:
//o &quot;You need a break, {брой незадоволителни оценки} poor grades.&quot;
//Средната оценка да бъде форматирана до втория знак след десетичната запетая.