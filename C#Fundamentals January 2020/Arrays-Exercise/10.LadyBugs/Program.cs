using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine()); //брой полета
            int[] indexWithBug = Console.ReadLine().Split().Select(int.Parse).ToArray();//позиции на които има буби

            int[] bugsPositions = new int[sizeOfField];//нов масив в който да се запазва къде има буби и къде не!

            string command = "";
            //bool hasBug = false;

            while (command != "end")
            {
                string[] action = command.Split();//{ladybug index}; {direction}; {flylength};

                for (int index = 0; index < sizeOfField; index++)
                {
                    for (int i = 0; i < indexWithBug.Length; i++)
                    {
                        if (indexWithBug[i] == index)
                        {
                            bugsPositions[i] = 1;
                            //hasBug = true;
                        }
                    }
                }
            }

        }
    }
}
