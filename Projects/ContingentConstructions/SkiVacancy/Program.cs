using System;

namespace SkiVacancy
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double nights = days - 1;
            double pricePerNight = 0;

            if (roomType == "room for one person")
            {
                pricePerNight = 18;
            }
            else if (roomType == "apartment")
            {
                pricePerNight = 25;
                if (days < 10)
                {
                    pricePerNight *= 0.7;
                }
                else if (days >= 10 && days <= 15)
                {
                    pricePerNight *= 0.65;
                }
                else if (days > 15)
                {
                    pricePerNight *= 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                pricePerNight = 35;
                if (days < 10)
                {
                    pricePerNight *= 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    pricePerNight *= 0.85;
                }
                else if (days > 15)
                {
                    pricePerNight *= 0.8;
                }
            }


            if (feedback == "positive")
            {
                double price = (pricePerNight * nights) * 1.25;
                Console.WriteLine("{0:f2}", price);
            }
            else if (feedback == "negative")
            {
                double price = (pricePerNight * nights) * 0.9;
                Console.WriteLine("{0:f2}", price);
            }
        }
    }
}
//* Ски почивка
// Атанас решава да прекара отпуската си в Банско и да кара ски.Преди да отиде обаче, трябва да резервира
//хотел и да изчисли колко ще му струва престоя.Съществуват следните видове помещения, със следните
//цени за престой:
// &quot;room for one person&quot; – 18.00 лв за нощувка
// &quot;apartment&quot; – 25.00 лв за нощувка
// &quot;president apartment&quot; – 35.00 лв за нощувка
//Според броят на дните, в които ще остане в хотела(пример: 11 дни = 10 нощувки) и видът на помещението,
//което ще избере, той може да ползва различно намаление.Намаленията са както следва:
//вид помещение по-малко от 10 дни между 10 и 15 дни повече от 15 дни
//room for one person не ползва намаление не ползва намаление не ползва намаление
//apartment 30% от крайната цена 35% от крайната цена 50% от крайната цена
//president apartment 10% от крайната цена 15% от крайната цена 20% от крайната цена
//След престоя, оценката на Атанас за услугите на хотела може да е позитивна(positive) или негативна
//(negative) . Ако оценката му е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25% от
//нея.Ако оценката му е негативна приспада от цената 10%.