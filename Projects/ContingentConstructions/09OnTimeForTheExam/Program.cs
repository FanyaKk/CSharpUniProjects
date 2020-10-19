using System;

namespace _09OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arriveH = int.Parse(Console.ReadLine());
            int arriveM = int.Parse(Console.ReadLine());

            double examTime = (examH * 60) + examM;
            double arrivalTime = (arriveH * 60) + arriveM;
            double difference = examTime - arrivalTime;
            double hours = 0;
            double minutes = 0;

            if (difference <= -1)
            {
                Console.WriteLine("Late");
            }
            else if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");
            }

            if (difference > 0 && difference < 60)
            {
                Console.WriteLine($"{difference} minutes before the start");
            }
            else if (difference >= 60)
            {
                hours = Math.Truncate(difference / 60); 
                //Math.Truncate - закръгля до цяло число спрямо нулата, тоест ако числото е -7.6 ще закръгли на -7, ако изпозлваме MathFloor, числото ще се закръгли на -8, а Math.Ceiling ще закръгли на -7.
                //                  5.8         -6.7
                //Мath.Floor        5           -7 
                //Math.Ceiling      6           -6 
                //Math.Truncate     5           -6
                minutes = Math.Abs(difference % 60);
                if (minutes < 10)
                {
                    Console.WriteLine($"{hours}:0{minutes} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes} hours before the start");
                }
            }
            else if (difference < 0 && difference >= -59)
            {
                Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
            }
            else if (difference <= -60)
            {
                hours = Math.Abs(Math.Truncate(difference / 60));
                minutes = Math.Abs(difference % 60);
                if (minutes < 10)
                {
                    Console.WriteLine($"{hours}:0{minutes} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes} hours after the start");
                }
            }
        }
    }
}
//Навреме за изпит

//Студент трябва да отиде на изпит в определен час(например в 9:30 часа). Той идва в изпитната зала в даден
//час на пристигане(например 9:40). Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на
//изпита или до половин час преди това.Ако е пристигнал по-рано повече от 30 минути, той е подранил.Ако е
//дошъл след часа на изпита, той е закъснял.Напишете програма, която прочита време на изпит и време на
//пристигане и отпечатва дали студентът е дошъл навреме, дали е подранил или е закъснял и с колко часа
//или минути е подранил или закъснял.
//Вход
//От конзолата се четат 4 цели числа (по едно на ред), въведени от потребителя:
// Първият ред съдържа час на изпита – цяло число от 0 до 23.
// Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
// Третият ред съдържа час на пристигане – цяло число от 0 до 23.
// Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
//Изход
//На първият ред отпечатайте:
// “Late”, ако студентът пристига по-късно от часа на изпита.
// “On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
// “Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
//Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
// “mm minutes before the start” за идване по-рано с по-малко от час.
// “hh:mm hours before the start” за подраняване с 1 час или повече. Минутите винаги печатайте с 2
//цифри, например “1:05”.
// “mm minutes after the start” за закъснение под час.
// “hh:mm hours after the start” за закъснение от 1 час или повече. Минутите винаги печатайте с 2
//цифри, например “1:03”.