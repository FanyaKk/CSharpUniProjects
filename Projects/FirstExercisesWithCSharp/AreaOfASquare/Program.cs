using System;

namespace AreaOfASquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            int area = side * side;

            Console.WriteLine(area);
        }
    }
}
//Пресмятане на лице на квадрат
//Да се напише конзолна програма, която въвежда цяло число "a" и пресмята лицето на квадрат със страна
//"a".