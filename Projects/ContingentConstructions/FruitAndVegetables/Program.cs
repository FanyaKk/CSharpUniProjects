using System;

namespace FruitAndVegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            string productType = Console.ReadLine();

            if ((productType == "banana") || (productType == "apple") || (productType == "kiwi") || (productType == "cherry") || (productType == "lemon") || (productType == "grapes"))
            {
                Console.WriteLine("fruit");
            }
            else if ((productType == "tomato") || (productType == "cucumber") || (productType == "pepper") || (productType == "carrot"))
            {
                Console.WriteLine("vegetables");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
//Плод или зеленчук
//Да се напише програма, която чете име на продукт, въведено от потребителя, и проверява дали е плод или
//зеленчук.
// Плодовете &quot;fruit&quot; имат следните възможни стойности: banana, apple, kiwi, cherry, lemon и grapes
// Зеленчуците &quot;vegetable&quot; имат следните възможни стойности: tomato, cucumber, pepper и carrot
// Всички останали са &quot;unknown&quot;
//Да се изведе &quot;fruit”, &quot;vegetable&quot; или &quot;unknown&quot; според въведения продукт.
