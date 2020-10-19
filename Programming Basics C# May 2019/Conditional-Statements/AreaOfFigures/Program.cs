using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0;

            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (figureType == "rectangle")
            {
                double heightSide = double.Parse(Console.ReadLine());
                double widthSide = double.Parse(Console.ReadLine());
                area = heightSide * widthSide;
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (figureType == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                area = triangleSide * triangleHeight / 2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
