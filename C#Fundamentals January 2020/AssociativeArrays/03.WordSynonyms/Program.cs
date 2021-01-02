using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)                 //version 2.0
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }
                words[word].Add(synonym);
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
        //static void Main(string[] args)               //version 1.0
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    Dictionary<string, List<string>> synonymList = new Dictionary<string, List<string>>();

        //    for (int i = 0; i < n; i++)
        //    {
        //        string word = Console.ReadLine();
        //        string synonym = Console.ReadLine();

        //        if (!synonymList.ContainsKey(word))
        //        {
        //            synonymList.Add(word, new List<string>());
        //        }
        //        synonymList[word].Add(synonym);              
        //    }
        //    foreach (var word in synonymList)
        //    {
        //        Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
        //    }
        //}
    }
}
//3. Word Synonyms

//Write a program, which keeps a dictionary with synonyms.The key of the dictionary will be the word. The value will
//be a list of all the synonyms of that word.You will be given a number n – the count of the words.After each word,
//you will be given a synonym, so the count of lines you have to read from the console is 2 * n.You will be receiving a
//word and a synonym each on a separate line like this:

// {word}
// {synonym}

//If you get the same word twice, just add the new synonym to the list.
//Print the words in the following format:
//{ word} - {synonym1, synonym2… synonymN}

//Examples   |
//Input      |   Output
//--------------------------------------------
//3          |   cute - adorable, charming
//cute       |   smart - clever
//adorable   |
//cute       |
//charming   |
//smart      |
//clever     |
//--------------------------------------------
//2          |   task – problem, assignment
//task       |
//problem    |
//task       |
//assignment |

//