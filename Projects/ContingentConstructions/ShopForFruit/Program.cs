using System;

namespace ShopForFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday") // логическо "или" - "||"
            {
                if (fruit == "banana")
                    price = 2.5;
                else if (fruit == "apple")
                    price = 1.2;
                else if (fruit == "orange")
                    price = 0.85;
                else if (fruit == "grapefruit")
                    price = 1.45;
                else if (fruit == "kiwi")
                    price = 2.70;
                else if (fruit == "pineapple")
                    price = 5.5;
                else if (fruit == "grapes")
                    price = 3.85;
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                    price = 2.7;
                else if (fruit == "apple")
                    price = 1.25;
                else if (fruit == "orange")
                    price = 0.90;
                else if (fruit == "grapefruit")
                    price = 1.60;
                else if (fruit == "kiwi")
                    price = 3.00;
                else if (fruit == "pineapple")
                    price = 5.6;
                else if (fruit == "grapes")
                    price = 4.2;
            }
            if (price >0)
            {
                Console.WriteLine("{0:f2}", price * quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
//Магазин за плодове
//Магазин за плодове през работните дни работи на следните цени:
//
//плод  banana  apple   orange  grapefruit  kiwi    pineapple   grapes
//цена  2.50    1.20     0.85      1.45     2.70       5.50      3.85
//
//Събота и неделя магазинът работи на по-високи цени:
//
//плод  banana  apple   orange  grapefruit  kiwi    pineapple   grapes
//цена  2.70    1.25     0.90      1.60     3.00       5.60      4.20
//
//Напишете програма, която чете от конзолата плод(banana / apple / orange / grapefruit / kiwi /
//pineapple / grapes), ден от седмицата(Monday / Tuesday / Wednesday / Thursday / Friday /
//Saturday / Sunday) и количество(реално число) , въведени от потребителя, и пресмята цената според
//цените от таблиците по-горе.Резултатът да се отпечата закръглен с 2 цифри след десетичната точка.При
//невалиден ден от седмицата или невалидно име на плод да се отпечата &quot; error&quot;.
