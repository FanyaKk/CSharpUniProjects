using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        while (number > 100 || number < 0)
        {
            Console.WriteLine("Invalid number");

            number = int.Parse(Console.ReadLine());
            if (number > 0 && number <= 100)
            {
                Console.WriteLine($"The number is:{number}");
                break;
            }
        }




        //--------------------------------------------------------------------------------------------------------------------------

        //int a = int.Parse(Console.ReadLine());

        //int expression = a++ + ++a;
        ////int expression = a++ + a++;
        //Console.WriteLine(expression);

        //--------------------------------------------------------------------------------------------------------------------------

        //Console.WriteLine("Запиши първо име, а после години.");
        //string name = Console.ReadLine();
        //int godini = int.Parse(Console.ReadLine());
        //Console.WriteLine("Моето име е {0}, аз съм на {1} годинки", name, godini);
        //if (name == "Georgi")
        //{
        //    Console.WriteLine("Ти си много велик и умен, защото си Георги");
        //}
        //else
        //{
        //    Console.WriteLine("Не ставаш за нищо");
        //}
    }
}
