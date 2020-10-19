using System;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            const double mm = 1000;
            const double cm = 100;

            if (inputUnit == "mm")
            {
                value /= mm;
            }
            else if (inputUnit == "cm")
            {
                value /= cm;
            }
            if (outputUnit == "mm")
            {
                value *= mm; 
            }
            else if (outputUnit == "cm")
            {
                value *= cm;
            }
            Console.WriteLine("{0:f3}", value);
        }
    }
}
//Конвертор за мерни единици
//Да се напише програма, която преобразува разстояние между следните 3 мерни единици: mm, cm, m.
//Използвайте съответствията от таблицата по-долу:

//входна единица изходна единица
//1 meter(m) 1000 millimeters(mm)
//1 meter(m) 100 centimeters(cm)
//Входните данни се състоят от три реда, въведени от потребителя:
// Първи ред: число за преобразуване - реално число
// Втори ред: входна мерна единица - текст
// Трети ред: изходна мерна единица(за резултата) - текст
//На конзолата да се отпечата резултатът от преобразуването на мерните единици форматиран до третия знак
//след десетичната запетая.