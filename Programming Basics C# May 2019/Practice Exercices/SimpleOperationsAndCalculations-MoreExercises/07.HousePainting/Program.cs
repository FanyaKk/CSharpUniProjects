using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseSideX = double.Parse(Console.ReadLine());
            double houseSideY = double.Parse(Console.ReadLine());
            double roofHeight = double.Parse(Console.ReadLine());

            double doorSize = 1.2 * 2;
            double houseWindow = 1.5 * 1.5;

            double frontAndBackSideSize = (houseSideX * houseSideX * 2) - doorSize;
            double leftAndRightSideSize = (houseSideX * houseSideY * 2) - (2 * houseWindow);
            double totalAreaForGreenPaint = frontAndBackSideSize + leftAndRightSideSize;

            double triangleRoofArea = houseSideX * roofHeight;
            double rectangleRoofArea = houseSideX * houseSideY * 2;
            double totalAreaForRedPaint = triangleRoofArea + rectangleRoofArea;

            double greenPaint = totalAreaForGreenPaint / 3.4;
            double redPaint = totalAreaForRedPaint / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
