using System;
using System.Text;
using System.Linq;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] number = Console.ReadLine().TrimStart('0').ToCharArray();
            int multiply = int.Parse(Console.ReadLine());

            StringBuilder sum = new StringBuilder();

            int reminder = 0;

            if(number.Length == 0 || multiply == 0)
            {
                Console.WriteLine('0');
                return;
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                char currNum = number[i];
                int num = int.Parse(currNum.ToString());
                int currResult = (num * multiply) + reminder;
                reminder = currResult / 10;
                int result = currResult % 10;

                sum.Append(result);
            }
            if (reminder != 0)
            {
                sum.Append(reminder);
            }
            

            char[] finalResult = sum.ToString()
                .Reverse()
                .ToArray();
            Console.WriteLine(string.Join("", finalResult));
        }
    }
}
