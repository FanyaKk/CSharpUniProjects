using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\").ToArray();

            string[] lastPath = path[path.Length-1].Split(".").ToArray();

            string fileExt = lastPath[lastPath.Length - 1];
            List<string> fileName = new List<string>();

            for (int i = 0; i < lastPath.Length-1; i++)
            {
                fileName.Add(lastPath[i]);
            }
            Console.WriteLine($"File name: {string.Join(".", fileName)}");
            Console.WriteLine($"File extension: {fileExt}");
        }
    }
}
