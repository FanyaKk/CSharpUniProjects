using System;

namespace _04.NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowerPrice = 0;

            if (flowerType == "Roses")
            {
                if (flowersCount > 80)
                {
                    flowerPrice = flowersCount * 5 * 0.9;
                }
                else
                {
                    flowerPrice = flowersCount * 5;
                }
            }
            else if (flowerType == "Dahlias")
            {
                if (flowersCount > 90)
                {
                    flowerPrice = flowersCount * 3.8 * 0.85;
                }
                else
                {
                    flowerPrice = flowersCount * 3.8;
                }
            }
            else if (flowerType == "Tulips")
            {
                if (flowersCount > 80)
                {
                    flowerPrice = flowersCount * 2.8 * 0.85;
                }
                else
                {
                    flowerPrice = flowersCount * 2.8;
                }
            }
            else if (flowerType == "Narcissus")
            {
                if (flowersCount < 120)
                {
                    flowerPrice = flowersCount * 3 * 1.15;
                }
                else
                {
                    flowerPrice = flowersCount * 3;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                if (flowersCount < 80)
                {
                    flowerPrice = flowersCount * 2.5 * 1.2;
                }
                else
                {
                    flowerPrice = flowersCount * 2.5;
                }
            }
            if (budget >= flowerPrice)
            {
                double leftBudget = budget - flowerPrice;
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowersCount, flowerType, leftBudget);
            }
            else if (budget < flowerPrice)
            {
                double needMoney = Math.Abs(budget - flowerPrice);
                Console.WriteLine("Not enough money, you need {0:f2} leva more.", needMoney);
            }
        }
    }
}
//Нов дом

//Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята, че Ви убеждава да
//напишете програма която да изчисли колко ще им струва, да си засадят определен брой цветя и дали
//наличния бюджет ще им е достатъчен. Различните цветя са с различни цени.

//      цвете               Роза        Далия       Лале        Нарцис      Гладиола
//  Цена на брой в лева       5         3.80        2.80           3          2.50
//
//Съществуват следните отстъпки:
// Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
// Ако Нели купи повече от 90 Далии - 15% отстъпка от крайната цена
// Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена
// Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%
// Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%
//
//От конзолата се четат 3 реда:
// Вид цветя - текст с възможности - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
// Брой цветя - цяло число в интервала[10…1000]
// Бюджет - цяло число в интервала[50…2500]
//
//Да се отпечата на конзолата на един ред:
// Ако бюджета им е достатъчен - "Hey, you have a great garden with { броя цвета } {вид цветя} and {останалата сума} leva left."
// Ако бюджета им е НЕ достатъчен - "Not enough money, you need { нужната сума } leva more."
//Сумата да бъде форматирана до втория знак след десетичната запетая.