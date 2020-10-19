using System;
using System.Text;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());

            int[] valueOfString = new int[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                double vowelResult = 0;
                double consonantResult = 0;
                double totalSum = 0;
                string name = Console.ReadLine();
                byte[] arrName = Encoding.ASCII.GetBytes(name);
                
                for (int letter = 0; letter < arrName.Length; letter++)
                {
                    bool isVowel = "aoueiAOUEI".IndexOf((char)arrName[letter]) >= 0;
                    if (isVowel == true)
                    {
                        vowelResult += arrName[letter] * name.Length;
                    }
                    else
                    {
                        consonantResult += arrName[letter] / name.Length;
                    }                    
                }
                totalSum = vowelResult + consonantResult;

                valueOfString[i] = (int)totalSum;
            }

            Array.Sort(valueOfString);
            for (int i = 0; i < numberOfStrings; i++)
            {
                Console.WriteLine(valueOfString[i]);
            }
        }
    }
}
