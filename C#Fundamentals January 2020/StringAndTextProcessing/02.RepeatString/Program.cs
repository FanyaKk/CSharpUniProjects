using System;
using System.Linq;
using System.Text;

namespace _02.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();

            StringBuilder result = new StringBuilder();
            //string result = "";

            foreach (var word in array)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    result.Append(word);
                }
            }
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array[i].Length; j++)
            //    {
            //        result += array[i];
            //    }
            //}
            Console.WriteLine(result);
        }
    }
}
