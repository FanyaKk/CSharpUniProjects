using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {

            int tableCounts = int.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double coverSize = tableCounts * (tableLength + (2 * 0.30)) * (tableWidth + (2 * 0.30));
            double coachSize = tableCounts * (tableLength / 2) * (tableLength / 2);

            double priceUSD = (coverSize * 7)+(coachSize * 9);
            double priceBGN = (coverSize * (7 * 1.85)) + (coachSize * (9 * 1.85));

            Console.WriteLine("{0:f2} USD", priceUSD);
            Console.WriteLine("{0:f2} BGN", priceBGN);
        }
    }
}
//Шивашки цех
//Шивашки цех приема поръчки за ушиване на покривки и карета за маси за заведения.Покривките са
//правоъгълни, каретата са квадратни, броят им винаги е еднакъв.Покривката трябва да виси с 30 см от всеки
//ръб на масата. Страната на каретата е половината от дължината на масите.Във всяка поръчка се включва
//информация за броя и размерите на масите.
//Напишете програма, която пресмята цената на поръчка в долари и в левове, като квадратен метър плат за
//правоъгълна покривка струва 7 долара, а за каре – 9 долара.Курсът на долара е 1.85 лева.