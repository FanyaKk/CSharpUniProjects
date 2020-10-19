using System;

namespace SameWords
{
    class SameWords
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();

            word1 = word1.ToLower(); // с метода "ToLower()" караме конзолата да прочете въведеният запис с малки букви, дори и той да е въведен с големи. В конкретният случай, може да се използва вместо ToLower(), ToUpper() - важното е да се приложи и за двете думи!
            word2 = word2.ToLower();

            if (word1 == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
//Еднакви думи
//Да се напише програма, която чете две думи, въведени от потребителя, и проверява дали са еднакви. Да не
//се прави разлика между главни и малки думи. Да се изведе "yes" или "no".