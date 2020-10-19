using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double centemeters = inches*2.54;

            Console.WriteLine("{0:f2}",centemeters);
        }
    }
}
//От инчове към сантиметри
//Да се напише програма, която чете от конзолата число(не непременно цяло) и преобразува числото от
//инчове в сантиметри.За целта умножава инчовете по 2.54 (защото 1 инч = 2.54 сантиметра).