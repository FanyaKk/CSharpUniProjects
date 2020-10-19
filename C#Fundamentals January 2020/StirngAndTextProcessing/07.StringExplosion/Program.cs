using System;
using System.Linq;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string textExplosion = Console.ReadLine();

            StringBuilder text = new StringBuilder();
            text.Append(textExplosion);

            string chrToNum = "";
            int strength = 0;
            int leftStrength = 0;

            for (int i = 0; i < text.Length - 1; i++)

            {
                if (text[i] == '>')
                {
                    chrToNum = text[i + 1].ToString();
                    strength = int.Parse(chrToNum) + leftStrength;
                    while (strength > 0 && i + 1 < text.Length)
                    {
                        if (text[i + 1] == '>')
                        {
                            leftStrength = strength;
                            break;
                        }
                        else
                        {
                            text.Remove(i + 1, 1);
                            strength--;
                        }
                    }
                }
            }
            Console.WriteLine(text);

            //string input = Console.ReadLine();
            //string strength = "";
            //int power = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == '>')
            //    {
            //        strength = input[i + 1].ToString();
            //        power += int.Parse(strength);

            //        while (power > 0 && i + 1 < input.Length)
            //        {
            //            if(input[i + 1] != '>')
            //            {
            //                input = input.Remove(i + 1, 1);
            //                power--;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(input);
        }
    }
}
//abv>1>1>2>2asdasd
