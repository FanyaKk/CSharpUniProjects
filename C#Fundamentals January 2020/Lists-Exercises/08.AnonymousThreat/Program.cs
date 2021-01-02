using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0]!="3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0 || startIndex > input.Count - 1)
                    {
                        startIndex = 0;
                    }
                    if (endIndex < 0 || endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        input[startIndex] += input[startIndex + 1];
                        input.RemoveAt(startIndex + 1);
                    }
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    StringBuilder strForDividing = new StringBuilder(input[index]);
                    int dividePartitions = strForDividing.Length / partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        result.Add(strForDividing.ToString().Substring(0, dividePartitions));
                        strForDividing.Remove(0, dividePartitions);
                    }
                    input.RemoveAt(index);

                    input.InsertRange(index, result);

                    if (strForDividing.ToString() != string.Empty)
                    {
                        input[partitions - 1] += strForDividing;
                    }             
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Console.WriteLine(string.Join(" ", input));
        }
        //static void Main(string[] args)               //version 1.0
        //{
        //    List<string> list = Console.ReadLine().Split(" ").ToList();

        //    //List<string> result = new List<string>();
        //    //string indexResult = "";
        //    string command = "";

        //    while ((command = Console.ReadLine()) != "3:1")
        //    {
        //        string[] input = command.Split().ToArray();
        //        if (input[0] == "merge")
        //        {
        //            int startIndex = int.Parse(input[1]);
        //            int endIndex = int.Parse(input[2]);

        //            Merge(list, startIndex, endIndex);
        //        }
        //        else if (input[0] == "divide")
        //        {
        //            int index = int.Parse(input[1]);
        //            int partitions = int.Parse(input[2]);

        //            Divide(list, index, partitions);

        //        }
        //    }
        //    Console.WriteLine(string.Join(" ", list));
        //}
        //static void Merge(List<string> list, int startIndex, int endIndex)
        //{
        //    if (startIndex < 0)
        //    {
        //        startIndex = 0;
        //    }
        //    if (endIndex > list.Count)
        //    {
        //        endIndex = list.Count - 1;
        //    }
        //    for (int i = startIndex + 1; i <= endIndex; i++)
        //    {
        //        list[startIndex] += list[startIndex + 1];
        //        list.RemoveAt(startIndex + 1);
        //    }
        //    //for (int i = 0; i < list.Count; i++)
        //    //{

        //    //    indexResult = list[i];

        //    //    for (int j = startIndex; j <= endIndex && j <= i && i <= endIndex; j++)
        //    //    {
        //    //        if (j == startIndex)
        //    //        {
        //    //            indexResult = "";
        //    //        }
        //    //        indexResult += list[j];
        //    //        i++;
        //    //        if (j == endIndex)
        //    //        {
        //    //            i--;
        //    //        }
        //    //    }
        //    //    result.Add(indexResult);
        //    //}
        //}
        //static void Divide(List<string> list, int index, int partitions)
        //{
        //    List<string> result = new List<string>();

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        string indexResult = list[i];

        //        string strForDividing = list[index];
        //        int dividePartitions = strForDividing.Length / partitions;
        //        int partCount = 0;

        //        string tempString = "";

        //        for (int j = 0; j < dividePartitions; j++)
        //        {
        //            //tempString += indexResult[];
        //        }
        //        for (int j = 1; j <= strForDividing.Length && i == index; j++)
        //        {
        //            if (j == 1)
        //            {
        //                indexResult = "";
        //            }
        //            indexResult += strForDividing[j - 1];
        //            if (j % dividePartitions == 0 && partCount < partitions)
        //            {
        //                indexResult += " ";
        //                partCount++;
        //            }
        //        }
        //        result.Add(indexResult);
        //        if (i + 1 == list.Count)
        //        {

        //        }

        //    }
        //    list = result;

        //    //result = new List<string>();
        //}
    }
}
//Exercise 8. * Anonymous Threat

// The Anonymous have created a cyber hypervirus, which steals data from the CIA.You, as the lead security developer
//in CIA, have been tasked to analyze the software of the virus and observe its actions on the data.The virus is known
//for his innovative and unbeleivably clever technique of merging and dividing data into partitions.
//You will receive a single input line, containing strings, separated by spaces.The strings may contain any ASCII
//character except whitespace.Then you will begin receiving commands in one of the following formats:

// merge {startIndex} {endIndex}
// divide {index} {partitions}

//Every time you receive the merge command, you must merge all elements from the startIndex, till the endIndex.In
//other words, you should concatenate them.
//Example: { abc, def, ghi} -> merge 0 1 -> {abcdef, ghi}
//If any of the given indexes is out of the array, you must take only the range that is inside the array and merge it.
//Every time you receive the divide command, you must divide the element at the given index, into several small
//substrings with equal length.The count of the substrings should be equal to the given partitions.
//Example: { abcdef, ghi, jkl} -> divide 0 3 -> {ab, cd, ef, ghi, jkl}
//If the string cannot be exactly divided into the given partitions, make all partitions except the last with equal
//lengths, and make the last one – the longest.
//Example: { abcd, efgh, ijkl} -> divide 0 3 -> {a, b, cd, efgh, ijkl}
//The input ends when you receive the command “3:1”. At that point you must print the resulting elements, joined
//by a space.

//Input

// The first input line will contain the array of data.
// On the next several input lines you will receive commands in the format specified above.
// The input ends when you receive the command "3:1".

//Output
// As output you must print a single line containing the elements of the array, joined by a space.

//Constrains
// The strings in the array may contain any ASCII character except whitespace.
// The startIndex and the endIndex will be in range[-1000, 1000].
// The endIndex will always be greater than the startIndex.
// The index in the divide command will always be inside the array.
// The partitions will be in range[0, 100].
// Allowed working time/memory: 100ms / 16MB.

//Examples

//Input                              |   Output
//--------------------------------------------------------------------------
//Ivo Johny Tony Bony Mony           |   IvoJohnyTonyBonyMony
//merge 0 3                          |
//merge 3 4                          |
//merge 0 3                          |
//3:1                                |
//--------------------------------------------------------------------------
//abcd efgh ijkl mnop qrst uvwx yz   |   abcd efgh ijkl mnop qr st uv wx yz
//merge 4 10                         |
//divide 4 5                         |
//3:1                                |