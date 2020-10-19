using System;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());//first brother's time
            double B = double.Parse(Console.ReadLine());//second brother's time
            double C = double.Parse(Console.ReadLine());//third brother's time
            double D = double.Parse(Console.ReadLine());//father's time

            double timeForCleaning = 1 / (1 / A + 1 / B + 1 / C);//three brother's time for cleaning
            double timeWithRest = timeForCleaning * 1.15;//in general time for cleaning with rest
            double leftTime = D - timeWithRest;//left time -> father's time for fishing - time for cleaning with rest

            Console.WriteLine("Cleaning time: {0:f2}", timeWithRest);//print cleaning time with rest

            if (timeWithRest >= 0)//If cleaning time with rest >=0, three brothers are surprise their father
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0:f0} hours.", Math.Floor(leftTime));//Math.Floor закръгля получената стойност до най-близкото число надолу! 
            }
            else//in other cases three brother are not surprise their.
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0:f0} hours.", Math.Ceiling(Math.Abs(leftTime)));//Math.Ceiling закръгля получената стойност до най-близкото число нагоре! 
            }
        }
    }
}
//Трима братя
//Трима братя решили да изненадат баща си, като почистят заедно гаража му.Големият брат чисти сам за
//определени часове - А.Средният брат чисти сам за В часа.По-малкият брат чисти сам за С часа.Бащата отива
//на риболов и няма да го има D часа.Към общото време за почистване се добавят 15% за почивка.
//Напишете програма, която пресмята дали тримата братя могат да изчистят заедно гаража и да изненадат
//баща си или не.
//Вход
//Входът се чете от конзолата и се състои от 4 реда:
// Времето на първият брат за чистене сам – реално число в интервала [0.00 … 99.00]
// Времето на вторият брат за чистене сам - реално число в интервала [0.00 … 99.00]
// Времето на третият брат за чистене сам - реално число в интервала [0.00 …99.00]
// Времето за риболов на бащата - реално число в интервала [0.00 … 99.00]
//Изход
//На конзолата трябва да се отпечатат два реда:
//1. Времето за чистене и почивка, форматирано до втори знак: "Cleaning time: {Времето за чистене }"
//2. Има ли изненада или не:
// Ако братята СА изненадали бащата(time left &gt;= 0): &quot;Yes, there is a surprise - time
//left -&gt; {остатък} hours.&quot; - резултатът трябва да е закръглен към по-малко цяло число(пр. 1.90 -
//&gt; 1).
// Ако братята НЕ СА изненадали бащата(time left &lt; 0): &quot;No, there isn&#39;сt a surprise -
//shortage of time -&gt; {недостиг} hours.&quot; - резултатът трябва да е закръглен към по-голямо
//цяло число(пр. 1.10 -&gt; 2).