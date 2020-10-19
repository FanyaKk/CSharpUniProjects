using System;

namespace Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double apartmentFreeSpace = width * length * hight;
            double apartmentTotalSpace = 0;
            double spaceDifference = 0;
            string input = Console.ReadLine();

            while (input != "Done")
            {
                int cartonCubic = int.Parse(input);

                apartmentTotalSpace += cartonCubic;
                spaceDifference = Math.Abs(apartmentTotalSpace - apartmentFreeSpace);
                if (apartmentTotalSpace > apartmentFreeSpace)
                {
                    Console.WriteLine($"No more free space! You need {spaceDifference} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{spaceDifference} Cubic meters left.");
            }
        }
    }
}
//* Преместване

//На осемнадесетия си рожден ден на Хосе взел решение, че ще се изнесе да живее на квартира.Опаковал
//багажа си в кашони и намерил подходяща обява за апартамент под наем. Той започва да пренася своя багаж
//на части, защото не може да пренесе целия наведнъж.Има ограничено свободно пространство в новото си
//жилище, където може да разположи вещите, така че мястото да бъде подходящо за живеене.
//Напишете програма, която изчислява свободния обем от жилището на Хосе, който остава след като
//пренесе багажа си.
//Бележка: Един кашон е с точни размери: 1m. x 1m. x 1m.

//Вход
//Потребителят въвежда следните данни на отделни редове:
//1. Широчина на свободното пространство - цяло число в интервала [1...1000]
//2. Дължина на свободното пространство - цяло число в интервала [1...1000]
//3. Височина на свободното пространство - цяло число в интервала [1...1000]
//4. На следващите редове (до получаване на команда &quot; Done&quot;) - брой кашони, които се пренасят в
//квартирата - цели числа в интервала[1...10000];
//Програмата трябва да приключи прочитането на данни при команда &quot;Done&quot; или ако свободното място
//свърши.
//Изход
//Да се отпечата на конзолата един от следните редове:
//- Ако стигнете до командата &quot;Done&quot; и има още свободно място:
//&quot;{брой свободни куб.метри} Cubic meters left.&quot;
//- Ако свободното място свърши преди да е дошла команда &quot;Done&quot;:
//&quot;No more free space! You need { брой недостигащи куб. метри }
//Cubic meters more.&quot;