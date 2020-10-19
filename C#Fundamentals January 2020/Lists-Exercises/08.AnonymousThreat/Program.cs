using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();

            //List<string> result = new List<string>();
            //string indexResult = "";
            string command = "";

            while((command = Console.ReadLine()) != "3:1")
            {
                string[] input = command.Split().ToArray();
                if (input[0] == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);

                    Merge(list, startIndex, endIndex);
                }
                else if (input[0] == "divide")
                {
                    int index = int.Parse(input[1]);
                    int partitions = int.Parse(input[2]);

                    Divide(list, index, partitions);
                    
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
        static void Merge(List<string> list, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex > list.Count)
            {
                endIndex = list.Count - 1;
            }
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                list[startIndex] += list[startIndex + 1];
                list.RemoveAt(startIndex + 1);
            }
            //for (int i = 0; i < list.Count; i++)
            //{

            //    indexResult = list[i];

            //    for (int j = startIndex; j <= endIndex && j <= i && i <= endIndex; j++)
            //    {
            //        if (j == startIndex)
            //        {
            //            indexResult = "";
            //        }
            //        indexResult += list[j];
            //        i++;
            //        if (j == endIndex)
            //        {
            //            i--;
            //        }
            //    }
            //    result.Add(indexResult);
            //}
        }
        static void Divide(List<string> list, int index, int partitions)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                string indexResult = list[i];

                string strForDividing = list[index];
                int dividePartitions = strForDividing.Length / partitions;
                int partCount = 0;

                string tempString = "";

                for (int j = 0; j < dividePartitions; j++)
                {
                    //tempString += indexResult[];
                }
                for (int j = 1; j <= strForDividing.Length && i == index; j++)
                {
                    if (j == 1)
                    {
                        indexResult = "";
                    }
                    indexResult += strForDividing[j - 1];
                    if (j % dividePartitions == 0 && partCount < partitions)
                    {
                        indexResult += " ";
                        partCount++;
                    }
                }
                result.Add(indexResult);
                if (i + 1 == list.Count)
                {
                    
                }

            }
            list = result;

            //result = new List<string>();
        }
    }
}
