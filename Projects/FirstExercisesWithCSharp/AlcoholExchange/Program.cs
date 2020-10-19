using System;

namespace AlcoholExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double beerCount = double.Parse(Console.ReadLine());
            double wineCount = double.Parse(Console.ReadLine());
            double rakiaCount = double.Parse(Console.ReadLine());
            double wiskeyCount = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice / 2;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);

            double rakiaSum = rakiaCount * rakiaPrice;
            double wineSum = wineCount * winePrice;
            double beerSum = beerCount * beerPrice;
            double wiskeySum = wiskeyCount * wiskeyPrice;

            double totalAmount = wiskeySum + rakiaSum + wineSum + beerSum;

           
           Console.WriteLine("{0:f2} лв.", totalAmount);
        }
    }
}
//Алкохолна борса
//Пешо решава да направи купон и отива до алкохолната борса за да купи бира, вино, ракия и уиски.На
//конзолата се въвежда цената на уискито в лв./л.и количеството на бирата, виното, ракията и уискито,
//които трябва да закупи. Да се напише програма, която пресмята колко пари са му необходими за да плати
//сметката, като знаете, че:
// цената на ракията е на половина по-ниска от тази на уискито;
// цената на виното е с 40% по-ниска от цената на ракията;
// цената на бирата е с 80% по-ниска от цената на ракията.