using System;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int nextNumber = int.Parse(number[i].ToString());

                if (i == 2)
                {
                    firstNumber = nextNumber;
                }
                else if (i == 1)
                {
                    secondNumber = nextNumber;
                }
                else if (i == 0)
                {
                    thirdNumber = nextNumber;
                }
                for (int j = 1; j <= firstNumber; j++)
                {
                    for (int k = 1; k <= secondNumber; k++)
                    {
                        for (int l = 1; l <= thirdNumber; l++)
                        {
                            double sum = j * k * l;
                            Console.WriteLine($"{j} * {k} * {l} = {sum};");
                        }
                    }
                }
            }
        }
    }
}
