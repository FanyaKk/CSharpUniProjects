using System;

namespace _03.SummerClothes
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string dayStatus = Console.ReadLine();

            string Outfit = string.Empty;
            string Shoes = string.Empty;

            if (degrees >= 10 && degrees <= 18)
            {
                if (dayStatus == "Morning")
                {
                    Outfit = "Sweatshirt";
                    Shoes = "Sneakers";
                }
                else if (dayStatus == "Afternoon" || dayStatus == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (dayStatus == "Morning" || dayStatus == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (dayStatus == "Afternoon")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
            }
            else if (degrees >= 25)
            {
                if (dayStatus == "Morning")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
                else if (dayStatus == "Afternoon")
                {
                    Outfit = "Suim Suit";
                    Shoes = "Barefoot";
                }
                else if (dayStatus == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
        }
    }
}
            //if (dayStatus == "morning")
            //{
            //    if (degrees >= 10 && degrees <=18)
            //    {
            //        Console.WriteLine("It's {0} degrees, get your Sweatshirt and Sneakers", degrees);
            //    }
            //    else if (degrees > 18 && degrees <= 24)
            //    {
            //        Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins", degrees);
            //    }
            //    else if (degrees >= 25)
            //    {
            //        Console.WriteLine("It's {0} degrees, get your T-shirt and Sandals", degrees);
            //    }
            //}
            //else if (dayStatus == "afternoon")
            //{
            //    if (degrees >= 10 && degrees <= 18)
            //    {
            //        Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins", degrees);
            //    }
            //    else if (degrees > 18 && degrees <= 24)
            //    {
            //        Console.WriteLine("It's {0} degrees, get your T-shirt and Sandals", degrees);
            //    }
            //    else if (degrees >= 25)
            //    {
            //        Console.WriteLine("It's {0} degrees, get your Swim Suit and Barefoot", degrees);
            //    }
            //}
            //else if (dayStatus == "evening")
            //{
            //    if (degrees >= 10)
            //    {
            //        Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins", degrees);
            //    }
            //}



//Лятно облекло

//Лято е с много променливо време и Виктор има нужда от вашата помощ.Напишете програма която спрямо
//времето от денонощието и градусите да препоръча на Виктор какви дрехи да си облече.Вашия приятел
//има различни планове за всеки етап от деня, които изискват и различен външен вид, тях може да видите от
//таблицата.
//От конзолата се четат точно два реда:
// Градусите - цяло число в интервала [10…42]
// Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening";
//
//      Време от
//      денонощието/градуси           Мorning                    Afternoon                      Evening
//
//      10 <= градуси <= 18     Outfit = Sweatshirt            Outfit = Shirt                Outfit = Shirt
//                               Shoes = Sneakers             Shoes = Moccasins             Shoes = Moccasins
//
//      18 < градуси <= 24      Outfit = Shirt                Outfit = T-Shirt               Outfit = Shirt
//                              Shoes = Moccasins              Shoes = Sandals              Shoes = Moccasins
//
//         градуси >= 25        Outfit = T-Shirt              Outfit = Swim Suit             Outfit = Shirt
//                              Shoes = Sandals                Shoes = Barefoot             Shoes = Moccasins
//
//Да се отпечата на конзолата на един ред: "It's {градуси} degrees, get your {облекло} and {обувки}.";