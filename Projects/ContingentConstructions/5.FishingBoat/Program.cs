using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            int fishers = int.Parse(Console.ReadLine());

            double rent = 0;
            double rentWithDiscount = 0;

            if (season == "spring")
            {
                if (fishers <= 6)
                {
                    rent = 3000 * 0.9;
                }
                else if (fishers <= 11)
                {
                    rent = 3000 * 0.85;
                }
                else if (fishers > 12)
                {
                    rent = 3000 * 0.75;
                }
            }
            else if (season == "summer" || season == "autumn")
            {
                if (fishers <= 6)
                {
                    rent = 4200 * 0.9;
                }
                else if (fishers <= 11)
                {
                    rent = 4200 * 0.85;
                }
                else if (fishers > 12)
                {
                    rent = 4200 * 0.75;
                }
            }
            else if (season == "winter")
            {
                if (fishers <= 6)
                {
                    rent = 2600 * 0.9;
                }
                else if (fishers <= 11)
                {
                    rent = 2600 * 0.85;
                }
                else if (fishers > 12)
                {
                    rent = 2600 * 0.75;
                }
            }
            if (fishers % 2 == 0 && season != "autumn")
            {
                rentWithDiscount = rent * 0.95;
            }
            else
            {
                rentWithDiscount = rent;
            }

            double leftMoney = Math.Abs(budget - rentWithDiscount);

            if (budget >= rentWithDiscount)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", leftMoney);
            }
            else if (budget < rentWithDiscount)
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", leftMoney);
            }
        }
    }
}
//Лодка за риболов
//Тони и приятели много обичали да ходят за риба, те са толкова запалени по риболова, че решават да отидат
//на риболов с кораб.Цената за наема на кораба зависи от сезона и броя рибари.
//Цената зависи от сезона:
// Цената за наем на кораба през пролетта е 3000 лв.
// Цената за наем на кораба през лятото и есента е 4200 лв.
// Цената за наем на кораба през зимата е 2600 лв.
//В зависимост от броя си групата ползва отстъпка:
// Ако групата е до 6 човека включително – отстъпка от 10%.
// Ако групата е от 7 до 11 човека включително – отстъпка от 15%.
// Ако групата е от 12 нагоре – отстъпка от 25%.
//Рибарите ползват допълнително 5% отстъпка, ако са четен брой освен ако не е есен - тогава нямат
//допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.
//Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари.
//Вход
//От конзолата се четат точно три реда.
// Бюджет на групата – цяло число в интервала [1…8000]
// Сезон – текст: "Spring", "Summer", "Autumn", "Winter"
// Брой рибари – цяло число в интервала[4…18]
//Изход
//Да се отпечата на конзолата един ред:
// Ако бюджетът е достатъчен:
//"Yes! You have { останалите пари } leva left."
// Ако бюджетът НЕ Е достатъчен:
//"Not enough money! You need { сумата, която не достига } leva."
//Сумите трябва да са форматирани с точност до два знака след десетичната запетая.