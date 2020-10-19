using System;

namespace _01.PointInARectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool firstCondition = (x == x1 || x == x2) && y >= y1 && y <= y2;
            bool secondCondition = (y == y1 || y == y2) && x >= x1 && x <= x2;

            if (firstCondition || secondCondition)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
//Точка върху страната на правоъгълник
//Напишете програма, която проверява дали точка { x, y }
//се намира върху някоя от страните на правоъгълник
//{ x1, y1 } – {x2, y2}. Входните данни се четат от конзолата и се състоят от 6 реда въведени от потребителя:
//десетичните числа x1, y1, x2, y2, x и y(като се гарантира, че x1 &lt; x2 и y1 &lt; y2). Да се отпечата &quot;Border&quot;
//(точката лежи на някоя от страните) или &quot;Inside / Outside&quot; (в противен случай).