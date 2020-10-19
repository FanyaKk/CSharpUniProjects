using System;

namespace FiguresArea
{
    class Program
    {
        static void Main(string[] args)
        {

            string figureType = Console.ReadLine();

            //    if (figureType == "square")
            //    {
            //        double squareSide = double.Parse(Console.ReadLine());
            //        double squareArea = squareSide * squareSide;
            //        Console.WriteLine(squareArea);
            //    }
            //    else if (figureType == "rectangle")
            //    {
            //        double rectangleLength = double.Parse(Console.ReadLine());
            //        double rectangleWidth = double.Parse(Console.ReadLine());
            //        double rectangleArea = rectangleLength * rectangleWidth;
            //        Console.WriteLine(rectangleArea);
            //    }
            //    else if (figureType == "circle")
            //    {
            //        double circleRadius = double.Parse(Console.ReadLine());
            //        double circleArea = Math.PI * (circleRadius * circleRadius);
            //        Console.WriteLine(circleArea);
            //    }
            //    else if (figureType == "triangle")
            //    {
            //        double triangleSide = double.Parse(Console.ReadLine());
            //        double trinagleHeight = double.Parse(Console.ReadLine());
            //        double triangleArea = (triangleSide * trinagleHeight) / 2;
            //        Console.WriteLine(triangleArea);
            //    }
            double area = 0.0;
            switch (figureType)
            {
                case "square":
                    {
                        double a = double.Parse(Console.ReadLine());
                        area = a * a;
                        break;
                    }
                case "rectangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        area = a * b;
                        break;
                    }
                case "circle":
                    {
                        double r = double.Parse(Console.ReadLine());
                        area = Math.PI * (r * r);
                        break;
                    }
                case "triangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        area = (a * h) / 2;
                        break;
                    }
            }
            //Console.WriteLine($"{area:f3}");
            Console.WriteLine("{0:f3}", area);
        }
    }
}
//Лица на фигури
//Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята
//лицето й.Фигурите са четири вида: квадрат (square), правоъгълник (rectangle), кръг (circle) и триъгълник
//(triangle). На първия ред на входа се чете вида на фигурата (square, rectangle, circle или triangle). Ако
//фигурата е квадрат, на следващия ред се чете едно число - дължина на страната му.Ако фигурата е
//правоъгълник, на следващите два реда четат две числа - дължините на страните му. Ако фигурата е кръг, на
//следващия ред чете едно число - радиусът на кръга.Ако фигурата е триъгълник, на следващите два реда
//четат две числа - дължината на страната му и дължината на височината към нея. Резултатът да се закръгли до
//3 цифри след десетичната точка.