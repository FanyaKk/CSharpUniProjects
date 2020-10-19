using System;

namespace PointInARectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x >= x1) && (x <= x2) && (y >= y1) && (y <= y2)) // логическо "и" "&&
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
//Точка в правоъгълник
//Напишете програма, която проверява дали точка { x, y}
//се намира вътре в правоъгълник {x1, y1} – {x2, y2}.
//Входните данни се четат от конзолата и се състоят от 6 реда, въведени от потребителя: десетичните числа x1,
//y1, x2, y2, x и y(като се гарантира, че x1 &lt; x2 и y1 &lt; y2). Една точка е вътрешна за даден правоъгълник, ако се
//намира някъде във вътрешността му или върху някоя от страните му.Отпечатайте &quot;Inside&quot; или &quot;Outside&quot;.