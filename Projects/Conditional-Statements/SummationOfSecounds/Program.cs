using System;

namespace SummationOfSecounds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeFirst = int.Parse(Console.ReadLine());
            int timeSecond = int.Parse(Console.ReadLine());
            int timeThird = int.Parse(Console.ReadLine());

            int totalTime = timeFirst + timeSecond + timeThird;

            int minutes = totalTime / 60;
            int secounds = totalTime % 60;// % се използва при деление с остатък, в случая за показване на остатък от деление на "totalTime" с посоченото число "60" след %.

            if (secounds < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, secounds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, secounds);
            }
        }
    }
}
//Сумиране на секунди
//Трима спортни състезатели финишират за някакъв брой секунди(между 1 и 50). Да се напише програма,
//която чете времената на състезателите в секунди, въведени от потребителя и пресмята сумарното им време
//във формат &quot;минути:секунди&quot;. Секундите да се изведат с водеща нула(2  &quot;02&quot;, 7  &quot;07&quot;, 35  &quot;35&quot;).