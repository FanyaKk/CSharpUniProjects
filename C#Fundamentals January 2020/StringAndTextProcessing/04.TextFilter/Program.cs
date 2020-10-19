using System;
using System.Text;
using System.Linq;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedList = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();

            for (int i = 0; i < bannedList.Length; i++)
            {
                text = text.Replace(bannedList[i], new string('*', bannedList[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
