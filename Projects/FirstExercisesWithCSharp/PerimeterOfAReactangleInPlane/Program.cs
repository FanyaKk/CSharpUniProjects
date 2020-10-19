using System;

namespace PerimeterOfAReactangleInPlane
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double length = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2); // Вградена функция за получаване на абсолютна стойност. Абсолютната стойност е модул от числото. Всяко число в модул е положитено( |-40|=40. По този начин полученият краен резултат винаги е положителен!

            double perimeter = 2 * (length + width);
            double area = length * width;

            Console.WriteLine("{0:f2} {1:f2}", perimeter, area);
        }
    }
}
//Лице на правоъгълник в равнината
//Правоъгълник е зададен с координатите на два от своите срещуположни ъгъла(x1, y1) – (x2, y2). Да се
//пресметнат площта и периметъра му.Входът се чете от конзолата.Числата x1, y1, x2 и y2 са дадени по едно
//наред.Изходът се извежда на конзолата и трябва да съдържа два реда с по една число на всеки от тях –
//лицето и периметъра.Резултатът да се форматира до 2 знака след запетаята.