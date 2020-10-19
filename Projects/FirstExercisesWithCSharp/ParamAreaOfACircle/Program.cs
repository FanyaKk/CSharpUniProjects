using System;

namespace ParamAreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;

            Console.WriteLine("{0:f2} {1:f2}", perimeter, area);
        }
    }
}
//Периметър и лице на кръг
//Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг /
//окръжност с радиус r, като форматирате изхода до втория знак след десетичната запетая.