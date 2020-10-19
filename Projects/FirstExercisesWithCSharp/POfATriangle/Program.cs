using System;

namespace POfATriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2;

            Console.WriteLine("{0:f2}", area);
        }
    }
}
//Лице на триъгълник
//Напишете програма, която чете от конзолата страна и височина на триъгълник и пресмята неговото лице.
//Използвайте формулата за лице на триъгълник: area = a* h / 2. Форматирате изхода до втория знак след
//десетичната запетая.